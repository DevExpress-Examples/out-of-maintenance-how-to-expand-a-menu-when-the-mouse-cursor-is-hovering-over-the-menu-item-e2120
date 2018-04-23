using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Q253018
{
    public class BarHelper
    {
        BarManager manager;

        public BarHelper(BarManager manager)
        {
            this.manager = manager;
        }


        public bool ExpandMenuOnMouseHover
        {
            set
            {
                manager.HighlightedLinkChanged -= OnBarManagerHighlightedLinkChanged;
                if (value)
                    manager.HighlightedLinkChanged += OnBarManagerHighlightedLinkChanged;
            }
        }

        private void OnBarManagerHighlightedLinkChanged(object sender, HighlightedLinkChangedEventArgs e)
        {
            Point mousePosition = manager.Form.PointToClient(Control.MousePosition);
            BarCustomContainerItemLink link = e.Link as BarCustomContainerItemLink;
            if (link != null && link.Bounds.Contains(mousePosition))
                link.OpenMenu();
        }

    }
}
