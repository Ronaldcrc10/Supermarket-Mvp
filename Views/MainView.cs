using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            BtnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };
            BtnProducts.Click += delegate { ShowProductViewDesing?.Invoke(this, EventArgs.Empty); };

            BtnExit.Click += delegate { this.Close(); };          

            
        }



        public event EventHandler ShowPayModeView;
        

        public event EventHandler ShowCategoriesView;

        public event EventHandler ShowProductViewDesing;
        
        public event EventHandler ShowProvidersView;
        private void MainView_Load(object sender, EventArgs e)
        {

        }
    }
}
