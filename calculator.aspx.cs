﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class calculator : System.Web.UI.Page
{
    static int op1, op2;
    static string op ;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = TextBox1.Text + "1";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = TextBox1.Text + "2";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        TextBox1.Text = TextBox1.Text + "3";
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        TextBox1.Text = TextBox1.Text + "4";
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        TextBox1.Text = TextBox1.Text + "5";
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        TextBox1.Text = TextBox1.Text + "6";
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        TextBox1.Text = TextBox1.Text + "7";
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        TextBox1.Text = TextBox1.Text + "8";
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        TextBox1.Text = TextBox1.Text + "9";
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        op1 = Convert.ToInt32(TextBox1.Text);
        op = ("+");
        TextBox1.Text="";


    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        op1 = Convert.ToInt32(TextBox1.Text);
        op = ("-");
        TextBox1.Text = "";
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        op2 = Convert.ToInt16(TextBox1.Text);
        switch (op)
        {case "+" :
                TextBox1.Text = Convert.ToString(op1 + op2);
                break;
        case "-":
                TextBox1.Text = Convert.ToString(op1 - op2);
                break;
          
        }
    }
}