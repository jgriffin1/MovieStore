﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MovieStore.web
{
  public partial class AddCreditCardType : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
      Response.Redirect("Categories.aspx");
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
      if (this.Page.IsValid)
      {
        this.Page.RegisterAsyncTask(new PageAsyncTask(SaveData));
      }
    }
    private async Task SaveData()
    {
      MovieStore.business.CreditCardType creditCardType = new MovieStore.business.CreditCardType()
      {
        Name = this.tboxCreditCardType.Text.Trim()
      };
      await creditCardType.addRecord();
      Response.Redirect("CreditCardTypes.aspx");

    }
  }
}