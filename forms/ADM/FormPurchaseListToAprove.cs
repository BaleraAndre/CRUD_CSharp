﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste.forms.ADM
{
    public partial class FormPurchaseListToAprove : Form
    {
        public FormPurchaseListToAprove()
        {
            InitializeComponent();
        }

        public static void GridLoad()
        {
            List<entities.Compra> compras = DataAccessObject.Purchase.purchaseDAO.GetUnapprovedPurchasesAsync().Result;


        }

      
    }
}
