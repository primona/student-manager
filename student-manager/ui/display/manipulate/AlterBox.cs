﻿using student_manager.info;
using student_manager.info.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_manager.ui.display.manipulate
{
    public abstract partial class AlterBox : Form
    {
        protected Entity _entity;

        public Action Confirming;

        public abstract void Confirm(bool confirmed = true);

        public Func<string, bool> IDVerifacator { set; protected get; }

        protected bool _isClean = true;

        public virtual Entity Entity
        {

            get => _entity;
            set
            {
                if (value == null || value == _entity)
                {

                    return;
                }

                    switch (value)
                    {
                        case Student _:
                            
                            lblTitle.Text = value.IsEmpty() ? "New Student" : "Edit Student";

                            break;
                        case Professor _:

                            lblTitle.Text = value.IsEmpty() ? "New Professor" : "Edit Professor";

                            break;
                    }

                _entity = value;
                }
        }

        public AlterBox()
        {
            InitializeComponent();
        }

        private void CancelRequested(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
