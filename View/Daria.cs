using System.Windows.Forms;
using LR3.Presenter;

namespace LR3
{
    public partial class Daria : Form, IFormView
    {
        private MainPresenter presenter;
        public Daria()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }
    }
}