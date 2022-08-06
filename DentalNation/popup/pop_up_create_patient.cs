
using System.Windows.Forms;

using DentalNation.source;

namespace DentalNation.popup
{
    public partial class pop_up_create_patient : Form
    {
        public pop_up_create_patient()
        {
            InitializeComponent();
            //CenterToParent();
            StartPosition = FormStartPosition.CenterParent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UIController.RestoreMainFocus();
        }
    }
}
