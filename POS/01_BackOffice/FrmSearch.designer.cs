using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Linq;
using System;
using System.Collections;

using System.Windows.Forms;

namespace POS
{
	public partial class FrmSearch :  Form 
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg = new System.Windows.Forms.DataGridView();
            this.txt = new DevExpress.XtraEditors.TextEdit();
            this.rbContains = new System.Windows.Forms.RadioButton();
            this.rbEquals = new System.Windows.Forms.RadioButton();
            this.rbEnd = new System.Windows.Forms.RadioButton();
            this.rbStart = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(5, 4);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dg.RowHeadersVisible = false;
            this.dg.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(672, 487);
            this.dg.TabIndex = 0;
            this.dg.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_ColumnHeaderMouseClick);
            this.dg.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dg_MouseDoubleClick);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(120, 536);
            this.txt.Name = "txt";
            this.txt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Properties.Appearance.Options.UseFont = true;
            this.txt.Size = new System.Drawing.Size(444, 26);
            this.txt.TabIndex = 1;
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // rbContains
            // 
            this.rbContains.AutoSize = true;
            this.rbContains.Checked = true;
            this.rbContains.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContains.Location = new System.Drawing.Point(447, 497);
            this.rbContains.Name = "rbContains";
            this.rbContains.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbContains.Size = new System.Drawing.Size(65, 20);
            this.rbContains.TabIndex = 3;
            this.rbContains.TabStop = true;
            this.rbContains.Text = "يحتوي";
            this.rbContains.UseVisualStyleBackColor = true;
            // 
            // rbEquals
            // 
            this.rbEquals.AutoSize = true;
            this.rbEquals.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEquals.Location = new System.Drawing.Point(241, 497);
            this.rbEquals.Name = "rbEquals";
            this.rbEquals.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbEquals.Size = new System.Drawing.Size(69, 20);
            this.rbEquals.TabIndex = 2;
            this.rbEquals.Text = "يساوي";
            this.rbEquals.UseVisualStyleBackColor = true;
            // 
            // rbEnd
            // 
            this.rbEnd.AutoSize = true;
            this.rbEnd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEnd.Location = new System.Drawing.Point(348, 497);
            this.rbEnd.Name = "rbEnd";
            this.rbEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbEnd.Size = new System.Drawing.Size(63, 20);
            this.rbEnd.TabIndex = 1;
            this.rbEnd.Text = "ينتهي";
            this.rbEnd.UseVisualStyleBackColor = true;
            // 
            // rbStart
            // 
            this.rbStart.AutoSize = true;
            this.rbStart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStart.Location = new System.Drawing.Point(155, 497);
            this.rbStart.Name = "rbStart";
            this.rbStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbStart.Size = new System.Drawing.Size(52, 20);
            this.rbStart.TabIndex = 0;
            this.rbStart.Text = "يبداء";
            this.rbStart.UseVisualStyleBackColor = true;
            // 
            // FrmSearch
            // 
 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 574);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.rbContains);
            this.Controls.Add(this.rbEquals);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.rbEnd);
            this.Controls.Add(this.rbStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmSearch";
            this.Text = "البحث";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSearch_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.DataGridView dg;
        internal DevExpress.XtraEditors.TextEdit txt;
        private RadioButton rbContains;
        private RadioButton rbEquals;
        private RadioButton rbEnd;
        private RadioButton rbStart;
	}
	
}
