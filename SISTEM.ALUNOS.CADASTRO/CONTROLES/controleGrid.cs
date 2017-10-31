using CORE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using CORE.Entidades;
using CORE.Extensao;

namespace CONTROLES
{
    public partial class ControleGrid : UserControl
    {
        public Func<dynamic> AdicionaItemNaGridDelegate = () => throw new NotImplementedException();
        public Action AtualizouDataGrid;
        private readonly BindingSource _bs = new BindingSource();
        public ControleGrid()
        {
            InitializeComponent();
        }

        public void InicializaGrid()
        {
            _bs.DataSource = new List<Item>();
            dgvControle.DataSource = _bs.List;
        }

        private void AdicionaItem(object item)
        {
            _bs.List.Add(item);
            _bs.ResetBindings(true);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var item = AdicionaItemNaGridDelegate();
            if (item == null) return;
            AdicionaItem(item);
            AtualizouDataGrid?.Invoke();
        }
        public void AddColumn(string headerText, string dataPropertyName, int width)
        {
            dgvControle.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = width,
                DataPropertyName = dataPropertyName,
                HeaderText = headerText,
                Name = dataPropertyName,
                HeaderCell = { ToolTipText = headerText }
            });
        }
    }
}
