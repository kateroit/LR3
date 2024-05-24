using System.Windows.Forms;
using LR3.Presenter;

namespace LR3
{
    public partial class Ekaterina : Form, IFormView
    {
        private MainPresenter presenter;
        public Ekaterina()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }
    }
}