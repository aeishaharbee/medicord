
namespace medicord_v1.Helpers
{
    public static class AvatarCache
    {
        private static readonly Dictionary<int, Bitmap?> _photos = new();

        public static Bitmap? Get(int userId) => _photos.TryGetValue(userId, out var b) ? b : null;

        public static void Clear()
        {
            foreach (var b in _photos.Values) b?.Dispose();
            _photos.Clear();
        }

        public static bool Preload(IEnumerable<int> ids)
        {
            var missing = ids.Where(i => i > 0 && !_photos.ContainsKey(i)).Distinct().ToList();
            if (missing.Count == 0) return false;

            for (int i = 0; i < missing.Count; i += 500)
            {
                var chunk = missing.Skip(i).Take(500).ToList();
                foreach (int id in chunk) _photos[id] = null;            

                string list = string.Join(",", chunk);                   
                DataTable t = Database.GetTable(
                    $"SELECT UserID, ProfilePhoto FROM Users WHERE UserID IN ({list}) AND ProfilePhoto IS NOT NULL");

                foreach (DataRow r in t.Rows)
                {
                    if (r["ProfilePhoto"] is byte[] bytes && bytes.Length > 0)
                    {
                        try { _photos[Convert.ToInt32(r["UserID"])] = ImageHelper.CircleFromBytes(bytes, 64); }
                        catch { /* keep initials */ }
                    }
                }
            }
            return true;
        }

        public static void PreloadFor(DataGridView g, Dictionary<string, string> map)
        {
            var ids = new List<int>();
            foreach (string idCol in map.Values.Distinct())
            {
                if (!g.Columns.Contains(idCol)) continue;
                foreach (DataGridViewRow row in g.Rows)
                {
                    var v = row.Cells[idCol].Value;
                    if (v != null && v != DBNull.Value) ids.Add(Convert.ToInt32(v));
                }
            }
            if (Preload(ids)) g.Invalidate();
        }
    }
}