﻿
using System;

namespace Kalkulator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.num1 = new System.Windows.Forms.Button();
            this.calculatorDisplay = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.clearEntryButton = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.reciprocalButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.rootButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(12, 231);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(84, 40);
            this.num1.TabIndex = 0;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // calculatorDisplay
            // 
            this.calculatorDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculatorDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorDisplay.Location = new System.Drawing.Point(12, 12);
            this.calculatorDisplay.Name = "calculatorDisplay";
            this.calculatorDisplay.Size = new System.Drawing.Size(318, 66);
            this.calculatorDisplay.TabIndex = 1;
            this.calculatorDisplay.Text = "0";
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(95, 231);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(84, 40);
            this.num2.TabIndex = 2;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(178, 231);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(84, 40);
            this.num3.TabIndex = 3;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(12, 192);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(84, 40);
            this.num4.TabIndex = 4;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(95, 192);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(84, 40);
            this.num5.TabIndex = 5;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(178, 192);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(84, 40);
            this.num6.TabIndex = 6;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num7
            // 
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(12, 153);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(84, 40);
            this.num7.TabIndex = 7;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(95, 153);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(84, 40);
            this.num8.TabIndex = 8;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(178, 153);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(84, 40);
            this.num9.TabIndex = 9;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // clearEntryButton
            // 
            this.clearEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntryButton.Location = new System.Drawing.Point(95, 79);
            this.clearEntryButton.Name = "clearEntryButton";
            this.clearEntryButton.Size = new System.Drawing.Size(84, 36);
            this.clearEntryButton.TabIndex = 11;
            this.clearEntryButton.Text = "CE";
            this.clearEntryButton.UseVisualStyleBackColor = true;
            this.clearEntryButton.Click += new System.EventHandler(this.clearEntryButton_Click);
            // 
            // num0
            // 
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(12, 270);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(167, 40);
            this.num0.TabIndex = 12;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(178, 270);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(84, 40);
            this.decimalButton.TabIndex = 13;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllButton.Location = new System.Drawing.Point(178, 79);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(84, 36);
            this.clearAllButton.TabIndex = 19;
            this.clearAllButton.Text = "C";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoButton.Location = new System.Drawing.Point(12, 79);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(84, 36);
            this.undoButton.TabIndex = 20;
            this.undoButton.Text = "←";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.Location = new System.Drawing.Point(261, 79);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(70, 36);
            this.divideButton.TabIndex = 21;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.Location = new System.Drawing.Point(261, 114);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(70, 40);
            this.multiplyButton.TabIndex = 22;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(261, 153);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(70, 40);
            this.minusButton.TabIndex = 23;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(261, 192);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(70, 40);
            this.plusButton.TabIndex = 24;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsButton.Location = new System.Drawing.Point(261, 231);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(70, 79);
            this.equalsButton.TabIndex = 25;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // reciprocalButton
            // 
            this.reciprocalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciprocalButton.Location = new System.Drawing.Point(12, 114);
            this.reciprocalButton.Name = "reciprocalButton";
            this.reciprocalButton.Size = new System.Drawing.Size(84, 40);
            this.reciprocalButton.TabIndex = 26;
            this.reciprocalButton.Text = "1/x";
            this.reciprocalButton.UseVisualStyleBackColor = true;
            this.reciprocalButton.Click += new System.EventHandler(this.reciprocalButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareButton.Location = new System.Drawing.Point(95, 114);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(84, 40);
            this.squareButton.TabIndex = 27;
            this.squareButton.Text = "x²";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // rootButton
            // 
            this.rootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootButton.Location = new System.Drawing.Point(178, 114);
            this.rootButton.Name = "rootButton";
            this.rootButton.Size = new System.Drawing.Size(84, 40);
            this.rootButton.TabIndex = 28;
            this.rootButton.Text = "√x";
            this.rootButton.UseVisualStyleBackColor = true;
            this.rootButton.Click += new System.EventHandler(this.rootButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 320);
            this.Controls.Add(this.rootButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.reciprocalButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.clearEntryButton);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.calculatorDisplay);
            this.Controls.Add(this.num1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Label calculatorDisplay;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button clearEntryButton;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button reciprocalButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button rootButton;
    }
}

