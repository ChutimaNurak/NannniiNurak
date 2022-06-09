namespace nMain.Design.Toolbox
{
	partial class frmListView
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.listView2 = new System.Windows.Forms.ListView();
			this.listView3 = new System.Windows.Forms.ListView();
			this.listView4 = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(39, 28);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(445, 240);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// listView2
			// 
			this.listView2.HideSelection = false;
			this.listView2.Location = new System.Drawing.Point(538, 28);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(445, 240);
			this.listView2.TabIndex = 1;
			this.listView2.UseCompatibleStateImageBehavior = false;
			// 
			// listView3
			// 
			this.listView3.HideSelection = false;
			this.listView3.Location = new System.Drawing.Point(39, 287);
			this.listView3.Name = "listView3";
			this.listView3.Size = new System.Drawing.Size(445, 240);
			this.listView3.TabIndex = 2;
			this.listView3.UseCompatibleStateImageBehavior = false;
			// 
			// listView4
			// 
			this.listView4.HideSelection = false;
			this.listView4.Location = new System.Drawing.Point(538, 287);
			this.listView4.Name = "listView4";
			this.listView4.Size = new System.Drawing.Size(445, 240);
			this.listView4.TabIndex = 3;
			this.listView4.UseCompatibleStateImageBehavior = false;
			// 
			// frmListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 619);
			this.Controls.Add(this.listView4);
			this.Controls.Add(this.listView3);
			this.Controls.Add(this.listView2);
			this.Controls.Add(this.listView1);
			this.Font = new System.Drawing.Font("Sylfaen", 10.2F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmListView";
			this.Text = "frmListView";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ListView listView3;
		private System.Windows.Forms.ListView listView4;
	}
}