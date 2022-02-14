using System.Windows.Forms;

namespace InternetProviderClient
{
    public static class Extensions
    {
        public static string GetEntityId(this DataGridView dgv) => dgv.SelectedRows[0].Cells[0].Value.ToString();
    }
}
