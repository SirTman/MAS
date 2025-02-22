﻿namespace MAS
{
    partial class MAS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TBMainTextWin = new System.Windows.Forms.RichTextBox();
            this.CurLocation = new System.Windows.Forms.Label();
            this.statBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelHPCurrent = new System.Windows.Forms.Label();
            this.labelHPMax = new System.Windows.Forms.Label();
            this.labelhpDiv = new System.Windows.Forms.Label();
            this.hitPointsBar = new System.Windows.Forms.ProgressBar();
            this.labelHP = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.intMod = new System.Windows.Forms.Label();
            this.preMod = new System.Windows.Forms.Label();
            this.cunMod = new System.Windows.Forms.Label();
            this.conMod = new System.Windows.Forms.Label();
            this.rfxMod = new System.Windows.Forms.Label();
            this.IntScore = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PreScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CunScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RfxScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StrScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.strMod = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ActionBar = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ActionBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBMainTextWin
            // 
            this.TBMainTextWin.BackColor = System.Drawing.SystemColors.Window;
            this.TBMainTextWin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBMainTextWin.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMainTextWin.HideSelection = false;
            this.TBMainTextWin.Location = new System.Drawing.Point(196, 44);
            this.TBMainTextWin.Name = "TBMainTextWin";
            this.TBMainTextWin.ReadOnly = true;
            this.TBMainTextWin.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TBMainTextWin.Size = new System.Drawing.Size(1054, 513);
            this.TBMainTextWin.TabIndex = 1;
            this.TBMainTextWin.Text = "Test";
            // 
            // CurLocation
            // 
            this.CurLocation.AutoSize = true;
            this.CurLocation.Font = new System.Drawing.Font("PF Ronda Seven", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurLocation.Location = new System.Drawing.Point(198, 9);
            this.CurLocation.Name = "CurLocation";
            this.CurLocation.Size = new System.Drawing.Size(184, 33);
            this.CurLocation.TabIndex = 3;
            this.CurLocation.Text = "LOCATION: ???";
            // 
            // statBox
            // 
            this.statBox.BackColor = System.Drawing.SystemColors.Control;
            this.statBox.Controls.Add(this.tableLayoutPanel2);
            this.statBox.Controls.Add(this.hitPointsBar);
            this.statBox.Controls.Add(this.labelHP);
            this.statBox.Controls.Add(this.tableLayoutPanel1);
            this.statBox.Controls.Add(this.label9);
            this.statBox.Font = new System.Drawing.Font("PF Ronda Seven", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statBox.Location = new System.Drawing.Point(12, 28);
            this.statBox.Name = "statBox";
            this.statBox.Size = new System.Drawing.Size(178, 619);
            this.statBox.TabIndex = 4;
            this.statBox.TabStop = false;
            this.statBox.Text = "Stats";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.labelHPCurrent, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelHPMax, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelhpDiv, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 463);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(155, 37);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // labelHPCurrent
            // 
            this.labelHPCurrent.AutoSize = true;
            this.labelHPCurrent.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHPCurrent.Location = new System.Drawing.Point(54, 0);
            this.labelHPCurrent.Name = "labelHPCurrent";
            this.labelHPCurrent.Size = new System.Drawing.Size(25, 27);
            this.labelHPCurrent.TabIndex = 15;
            this.labelHPCurrent.Text = "0";
            this.labelHPCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHPMax
            // 
            this.labelHPMax.AutoSize = true;
            this.labelHPMax.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHPMax.Location = new System.Drawing.Point(3, 0);
            this.labelHPMax.Name = "labelHPMax";
            this.labelHPMax.Size = new System.Drawing.Size(25, 27);
            this.labelHPMax.TabIndex = 14;
            this.labelHPMax.Text = "0";
            this.labelHPMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelhpDiv
            // 
            this.labelhpDiv.AutoSize = true;
            this.labelhpDiv.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhpDiv.Location = new System.Drawing.Point(34, 0);
            this.labelhpDiv.Name = "labelhpDiv";
            this.labelhpDiv.Size = new System.Drawing.Size(14, 27);
            this.labelhpDiv.TabIndex = 13;
            this.labelhpDiv.Text = "/";
            this.labelhpDiv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hitPointsBar
            // 
            this.hitPointsBar.Location = new System.Drawing.Point(14, 434);
            this.hitPointsBar.Maximum = 0;
            this.hitPointsBar.Name = "hitPointsBar";
            this.hitPointsBar.Size = new System.Drawing.Size(155, 23);
            this.hitPointsBar.Step = 1;
            this.hitPointsBar.TabIndex = 1;
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F);
            this.labelHP.Location = new System.Drawing.Point(9, 404);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(38, 27);
            this.labelHP.TabIndex = 0;
            this.labelHP.Text = "HP";
            this.labelHP.Click += new System.EventHandler(this.labelHP_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.intMod, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.preMod, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.cunMod, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.conMod, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.rfxMod, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.IntScore, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.PreScore, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.CunScore, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ConScore, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.RfxScore, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.StrScore, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.strMod, 2, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(171, 360);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // intMod
            // 
            this.intMod.AutoSize = true;
            this.intMod.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intMod.Location = new System.Drawing.Point(112, 295);
            this.intMod.Name = "intMod";
            this.intMod.Size = new System.Drawing.Size(38, 27);
            this.intMod.TabIndex = 16;
            this.intMod.Text = "??";
            this.intMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // preMod
            // 
            this.preMod.AutoSize = true;
            this.preMod.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preMod.Location = new System.Drawing.Point(112, 236);
            this.preMod.Name = "preMod";
            this.preMod.Size = new System.Drawing.Size(38, 27);
            this.preMod.TabIndex = 15;
            this.preMod.Text = "??";
            this.preMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cunMod
            // 
            this.cunMod.AutoSize = true;
            this.cunMod.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cunMod.Location = new System.Drawing.Point(112, 177);
            this.cunMod.Name = "cunMod";
            this.cunMod.Size = new System.Drawing.Size(38, 27);
            this.cunMod.TabIndex = 14;
            this.cunMod.Text = "??";
            this.cunMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conMod
            // 
            this.conMod.AutoSize = true;
            this.conMod.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conMod.Location = new System.Drawing.Point(112, 118);
            this.conMod.Name = "conMod";
            this.conMod.Size = new System.Drawing.Size(38, 27);
            this.conMod.TabIndex = 13;
            this.conMod.Text = "??";
            this.conMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rfxMod
            // 
            this.rfxMod.AutoSize = true;
            this.rfxMod.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfxMod.Location = new System.Drawing.Point(112, 59);
            this.rfxMod.Name = "rfxMod";
            this.rfxMod.Size = new System.Drawing.Size(38, 27);
            this.rfxMod.TabIndex = 12;
            this.rfxMod.Text = "??";
            this.rfxMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntScore
            // 
            this.IntScore.AutoSize = true;
            this.IntScore.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntScore.Location = new System.Drawing.Point(68, 295);
            this.IntScore.Name = "IntScore";
            this.IntScore.Size = new System.Drawing.Size(38, 27);
            this.IntScore.TabIndex = 11;
            this.IntScore.Text = "??";
            this.IntScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IntScore.TextChanged += new System.EventHandler(this.IntScore_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "INT";
            // 
            // PreScore
            // 
            this.PreScore.AutoSize = true;
            this.PreScore.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreScore.Location = new System.Drawing.Point(68, 236);
            this.PreScore.Name = "PreScore";
            this.PreScore.Size = new System.Drawing.Size(38, 27);
            this.PreScore.TabIndex = 10;
            this.PreScore.Text = "??";
            this.PreScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PreScore.TextChanged += new System.EventHandler(this.PreScore_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "PRE";
            // 
            // CunScore
            // 
            this.CunScore.AutoSize = true;
            this.CunScore.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CunScore.Location = new System.Drawing.Point(68, 177);
            this.CunScore.Name = "CunScore";
            this.CunScore.Size = new System.Drawing.Size(38, 27);
            this.CunScore.TabIndex = 9;
            this.CunScore.Text = "??";
            this.CunScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CunScore.TextChanged += new System.EventHandler(this.CunScore_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "CUN";
            // 
            // ConScore
            // 
            this.ConScore.AutoSize = true;
            this.ConScore.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConScore.Location = new System.Drawing.Point(68, 118);
            this.ConScore.Name = "ConScore";
            this.ConScore.Size = new System.Drawing.Size(38, 27);
            this.ConScore.TabIndex = 8;
            this.ConScore.Text = "??";
            this.ConScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ConScore.TextChanged += new System.EventHandler(this.ConScore_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "CON";
            // 
            // RfxScore
            // 
            this.RfxScore.AutoSize = true;
            this.RfxScore.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RfxScore.Location = new System.Drawing.Point(68, 59);
            this.RfxScore.Name = "RfxScore";
            this.RfxScore.Size = new System.Drawing.Size(38, 27);
            this.RfxScore.TabIndex = 7;
            this.RfxScore.Text = "??";
            this.RfxScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RfxScore.TextChanged += new System.EventHandler(this.RfxScore_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "RFX";
            // 
            // StrScore
            // 
            this.StrScore.AutoSize = true;
            this.StrScore.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrScore.Location = new System.Drawing.Point(68, 0);
            this.StrScore.Name = "StrScore";
            this.StrScore.Size = new System.Drawing.Size(38, 27);
            this.StrScore.TabIndex = 6;
            this.StrScore.Text = "??";
            this.StrScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StrScore.TextChanged += new System.EventHandler(this.StrScore_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "STR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // strMod
            // 
            this.strMod.AutoSize = true;
            this.strMod.Font = new System.Drawing.Font("PF Ronda Seven", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strMod.Location = new System.Drawing.Point(112, 0);
            this.strMod.Name = "strMod";
            this.strMod.Size = new System.Drawing.Size(38, 27);
            this.strMod.TabIndex = 7;
            this.strMod.Text = "??";
            this.strMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(139, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "??";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActionBar
            // 
            this.ActionBar.Controls.Add(this.button1);
            this.ActionBar.Controls.Add(this.button2);
            this.ActionBar.Controls.Add(this.button3);
            this.ActionBar.Controls.Add(this.button4);
            this.ActionBar.Controls.Add(this.button5);
            this.ActionBar.Controls.Add(this.button6);
            this.ActionBar.Controls.Add(this.button7);
            this.ActionBar.Controls.Add(this.button8);
            this.ActionBar.Controls.Add(this.button9);
            this.ActionBar.Location = new System.Drawing.Point(196, 563);
            this.ActionBar.Name = "ActionBar";
            this.ActionBar.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ActionBar.Size = new System.Drawing.Size(1054, 84);
            this.ActionBar.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(3, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(120, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(237, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(354, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(471, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 50);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(588, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 50);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(705, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 50);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Location = new System.Drawing.Point(822, 13);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 50);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.Location = new System.Drawing.Point(939, 13);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(111, 50);
            this.button9.TabIndex = 8;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.ActionBar);
            this.Controls.Add(this.statBox);
            this.Controls.Add(this.CurLocation);
            this.Controls.Add(this.TBMainTextWin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MAS";
            this.Text = "MAS";
            this.Load += new System.EventHandler(this.MAS_Load);
            this.statBox.ResumeLayout(false);
            this.statBox.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ActionBar.ResumeLayout(false);
            this.ActionBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.RichTextBox TBMainTextWin;
        private System.Windows.Forms.Label CurLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label IntScore;
        public System.Windows.Forms.Label PreScore;
        public System.Windows.Forms.Label CunScore;
        public System.Windows.Forms.Label ConScore;
        public System.Windows.Forms.Label RfxScore;
        public System.Windows.Forms.Label StrScore;
        private System.Windows.Forms.FlowLayoutPanel ActionBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        public System.Windows.Forms.GroupBox statBox;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.ProgressBar hitPointsBar;
        public System.Windows.Forms.Label strMod;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label intMod;
        public System.Windows.Forms.Label preMod;
        public System.Windows.Forms.Label cunMod;
        public System.Windows.Forms.Label conMod;
        public System.Windows.Forms.Label rfxMod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label labelhpDiv;
        public System.Windows.Forms.Label labelHPCurrent;
        public System.Windows.Forms.Label labelHPMax;
    }
}

