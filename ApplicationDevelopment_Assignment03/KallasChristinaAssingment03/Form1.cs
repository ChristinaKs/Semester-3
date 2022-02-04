using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KallasChristinaAssingment03_Restarted
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void additionButton_Click(object sender, EventArgs e)
        {
            // create the two original HugeInteger
            HugeInteger hugeInt1 = new HugeInteger();
            HugeInteger hugeInt2 = new HugeInteger();

            // input strings into the HugeInteger objects
            hugeInt1.Input(firstNumberInputTextBox.Text);
            hugeInt2.Input(secondNumberInputTextBox.Text);

            // perform calculations
            HugeInteger additionOutput = hugeInt1.Addition(hugeInt2);

            // display the result
            outputLabel.Text = additionOutput.ToString();

            // initiate all checkboxes to false
            isEqualCheckBox.Checked = false;
            isGreaterThanCheckBox.Checked = false;
            isGreaterThanOrEqualToCheckBox.Checked = false;
            isLessThanCheckBox.Checked = false;
            isLessThanOrEqualToCheckBox.Checked = false;
            isNotEqualCheckBox.Checked = false;
            isZeroCheckbox.Checked = false;

            // check if they are equal
            if (hugeInt1.IsEquals(hugeInt2) == true)
            {
                isEqualCheckBox.Checked = true;
                isNotEqualCheckBox.Checked = false; // opposite
                isGreaterThanOrEqualToCheckBox.Checked = true; // inclusive
                isLessThanOrEqualToCheckBox.Checked = true; // inclusive
            }

            // check if theyre not equal
            if (hugeInt1.IsNotEquals(hugeInt2) == true)
            {
                isEqualCheckBox.Checked = false;
                isNotEqualCheckBox.Checked = true; // opposite
            }

            // check if 1 > 2
            if (hugeInt1.IsGreaterThan(hugeInt2) == true)
            {
                isGreaterThanOrEqualToCheckBox.Checked = true;
                isGreaterThanCheckBox.Checked = true; // inclusive
                isLessThanCheckBox.Checked = false; // opposite
                isLessThanOrEqualToCheckBox.Checked = false; // opposite
                isEqualCheckBox.Checked = false; // opposite
                isNotEqualCheckBox.Checked = true; // inclusive
            }

            // check if 1 < 2
            if (hugeInt1.IsLessThan(hugeInt2) == true)
            {
                isLessThanCheckBox.Checked = true;
                isLessThanOrEqualToCheckBox.Checked = true; // inclusive
                isGreaterThanOrEqualToCheckBox.Checked = false; // opposite
                isGreaterThanCheckBox.Checked = false; // opposite
                isEqualCheckBox.Checked = false; // opposite
                isNotEqualCheckBox.Checked = true; // inclusive
            }

            // check if 1 >= 2
            if (hugeInt1.IsGreaterThanOrEquals(hugeInt2) == true)
            {
                isGreaterThanOrEqualToCheckBox.Checked = true;
            }

            // check if 1 <= 2
            if (hugeInt1.IsLessThanOrEquals(hugeInt2) == true)
            {
                isLessThanOrEqualToCheckBox.Checked = true;
            }

            // check if either number is = 0
            if (hugeInt1.IsZero() == true || hugeInt2.IsZero() == true)
            {
                isZeroCheckbox.Checked = true;
            }
        }


        private void divisionButton_Click(object sender, EventArgs e)
        {
            // create the two original HugeInteger
            HugeInteger hugeInt1 = new HugeInteger();
            HugeInteger hugeInt2 = new HugeInteger();

            // input strings into the HugeInteger objects
            hugeInt1.Input(firstNumberInputTextBox.Text);
            hugeInt2.Input(secondNumberInputTextBox.Text);

            // perform calculations
            HugeInteger divisionOutput = hugeInt1.Division(hugeInt2);

            // display the result
            outputLabel.Text = divisionOutput.ToString();

            // initiate all checkboxes to false
            isEqualCheckBox.Checked = false;
            isGreaterThanCheckBox.Checked = false;
            isGreaterThanOrEqualToCheckBox.Checked = false;
            isLessThanCheckBox.Checked = false;
            isLessThanOrEqualToCheckBox.Checked = false;
            isNotEqualCheckBox.Checked = false;
            isZeroCheckbox.Checked = false;

            // check if they are equal
            if (hugeInt1.IsEquals(hugeInt2) == true)
            {
                isEqualCheckBox.Checked = true;
                isNotEqualCheckBox.Checked = false; // opposite
                isGreaterThanOrEqualToCheckBox.Checked = true; // inclusive
                isLessThanOrEqualToCheckBox.Checked = true; // inclusive
            }

            // check if theyre not equal
            if (hugeInt1.IsNotEquals(hugeInt2) == true)
            {
                isEqualCheckBox.Checked = false;
                isNotEqualCheckBox.Checked = true; // opposite
            }

            // check if 1 > 2
            if (hugeInt1.IsGreaterThan(hugeInt2) == true)
            {
                isGreaterThanOrEqualToCheckBox.Checked = true;
                isGreaterThanCheckBox.Checked = true; // inclusive
                isLessThanCheckBox.Checked = false; // opposite
                isLessThanOrEqualToCheckBox.Checked = false; // opposite
                isEqualCheckBox.Checked = false; // opposite
                isNotEqualCheckBox.Checked = true; // inclusive
            }

            // check if 1 < 2
            if (hugeInt1.IsLessThan(hugeInt2) == true)
            {
                isLessThanCheckBox.Checked = true;
                isLessThanOrEqualToCheckBox.Checked = true; // inclusive
                isGreaterThanOrEqualToCheckBox.Checked = false; // opposite
                isGreaterThanCheckBox.Checked = false; // opposite
                isEqualCheckBox.Checked = false; // opposite
                isNotEqualCheckBox.Checked = true; // inclusive
            }

            // check if 1 >= 2
            if (hugeInt1.IsGreaterThanOrEquals(hugeInt2) == true)
            {
                isGreaterThanOrEqualToCheckBox.Checked = true;
            }

            // check if 1 <= 2
            if (hugeInt1.IsLessThanOrEquals(hugeInt2) == true)
            {
                isLessThanOrEqualToCheckBox.Checked = true;
            }

            // check if either number is = 0
            if (hugeInt1.IsZero() == true || hugeInt2.IsZero() == true)
            {
                isZeroCheckbox.Checked = true;
            }
        }

        private void substractionButton_Click(object sender, EventArgs e)
        {
            // create the two original HugeInteger
            HugeInteger hugeInt1 = new HugeInteger();
            HugeInteger hugeInt2 = new HugeInteger();

            // input strings into the HugeInteger objects
            hugeInt1.Input(firstNumberInputTextBox.Text);
            hugeInt2.Input(secondNumberInputTextBox.Text);

            // perform calculations
            HugeInteger subtractionOutput = hugeInt1.Subtraction(hugeInt2);

            // display the result
            outputLabel.Text = subtractionOutput.ToString();

            // initiate all checkboxes to false
            isEqualCheckBox.Checked = false;
            isGreaterThanCheckBox.Checked = false;
            isGreaterThanOrEqualToCheckBox.Checked = false;
            isLessThanCheckBox.Checked = false;
            isLessThanOrEqualToCheckBox.Checked = false;
            isNotEqualCheckBox.Checked = false;
            isZeroCheckbox.Checked = false;

            // check if they are equal
            if (hugeInt1.IsEquals(hugeInt2) == true)
            {
                isEqualCheckBox.Checked = true;
                isNotEqualCheckBox.Checked = false; // opposite
                isGreaterThanOrEqualToCheckBox.Checked = true; // inclusive
                isLessThanOrEqualToCheckBox.Checked = true; // inclusive
            }

            // check if theyre not equal
            if (hugeInt1.IsNotEquals(hugeInt2) == true)
            {
                isEqualCheckBox.Checked = false;
                isNotEqualCheckBox.Checked = true; // opposite
            }

            // check if 1 > 2
            if (hugeInt1.IsGreaterThan(hugeInt2) == true)
            {
                isGreaterThanOrEqualToCheckBox.Checked = true;
                isGreaterThanCheckBox.Checked = true; // inclusive
                isLessThanCheckBox.Checked = false; // opposite
                isLessThanOrEqualToCheckBox.Checked = false; // opposite
                isEqualCheckBox.Checked = false; // opposite
                isNotEqualCheckBox.Checked = true; // inclusive
            }

            // check if 1 < 2
            if (hugeInt1.IsLessThan(hugeInt2) == true)
            {
                isLessThanCheckBox.Checked = true;
                isLessThanOrEqualToCheckBox.Checked = true; // inclusive
                isGreaterThanOrEqualToCheckBox.Checked = false; // opposite
                isGreaterThanCheckBox.Checked = false; // opposite
                isEqualCheckBox.Checked = false; // opposite
                isNotEqualCheckBox.Checked = true; // inclusive
            }

            // check if 1 >= 2
            if (hugeInt1.IsGreaterThanOrEquals(hugeInt2) == true)
            {
                isGreaterThanOrEqualToCheckBox.Checked = true;
            }

            // check if 1 <= 2
            if (hugeInt1.IsLessThanOrEquals(hugeInt2) == true)
            {
                isLessThanOrEqualToCheckBox.Checked = true;
            }

            // check if either number is = 0
            if (hugeInt1.IsZero() == true || hugeInt2.IsZero() == true)
            {
                isZeroCheckbox.Checked = true;
            }
        }

        private void remainderButton_Click(object sender, EventArgs e)
        {
            // create the two original HugeInteger
            HugeInteger hugeInt1 = new HugeInteger();
            HugeInteger hugeInt2 = new HugeInteger();

            // input strings into the HugeInteger objects
            hugeInt1.Input(firstNumberInputTextBox.Text);
            hugeInt2.Input(secondNumberInputTextBox.Text);

            // perform calculations
            HugeInteger remainderOutput = hugeInt1.Remainder(hugeInt2);

            // display the result
            outputLabel.Text = remainderOutput.ToString();

            // initiate all checkboxes to false
            isEqualCheckBox.Checked = false;
            isGreaterThanCheckBox.Checked = false;
            isGreaterThanOrEqualToCheckBox.Checked = false;
            isLessThanCheckBox.Checked = false;
            isLessThanOrEqualToCheckBox.Checked = false;
            isNotEqualCheckBox.Checked = false;
            isZeroCheckbox.Checked = false;

            // check if they are equal
            if (hugeInt1.IsEquals(hugeInt2) == true)
            {
                isEqualCheckBox.Checked = true;
                isNotEqualCheckBox.Checked = false; // opposite
                isGreaterThanOrEqualToCheckBox.Checked = true; // inclusive
                isLessThanOrEqualToCheckBox.Checked = true; // inclusive
            }

            // check if theyre not equal
            if (hugeInt1.IsNotEquals(hugeInt2) == true)
            {
                isEqualCheckBox.Checked = false;
                isNotEqualCheckBox.Checked = true; // opposite
            }

            // check if 1 > 2
            if (hugeInt1.IsGreaterThan(hugeInt2) == true)
            {
                isGreaterThanOrEqualToCheckBox.Checked = true;
                isGreaterThanCheckBox.Checked = true; // inclusive
                isLessThanCheckBox.Checked = false; // opposite
                isLessThanOrEqualToCheckBox.Checked = false; // opposite
                isEqualCheckBox.Checked = false; // opposite
                isNotEqualCheckBox.Checked = true; // inclusive
            }

            // check if 1 < 2
            if (hugeInt1.IsLessThan(hugeInt2) == true)
            {
                isLessThanCheckBox.Checked = true;
                isLessThanOrEqualToCheckBox.Checked = true; // inclusive
                isGreaterThanOrEqualToCheckBox.Checked = false; // opposite
                isGreaterThanCheckBox.Checked = false; // opposite
                isEqualCheckBox.Checked = false; // opposite
                isNotEqualCheckBox.Checked = true; // inclusive
            }

            // check if 1 >= 2
            if (hugeInt1.IsGreaterThanOrEquals(hugeInt2) == true)
            {
                isGreaterThanOrEqualToCheckBox.Checked = true;
            }

            // check if 1 <= 2
            if (hugeInt1.IsLessThanOrEquals(hugeInt2) == true)
            {
                isLessThanOrEqualToCheckBox.Checked = true;
            }

            // check if either number is = 0
            if (hugeInt1.IsZero() == true || hugeInt2.IsZero() == true)
            {
                isZeroCheckbox.Checked = true;
            }
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            // create the two original HugeInteger
            HugeInteger hugeInt1 = new HugeInteger();
            HugeInteger hugeInt2 = new HugeInteger();

            // input strings into the HugeInteger objects
            hugeInt1.Input(firstNumberInputTextBox.Text);
            hugeInt2.Input(secondNumberInputTextBox.Text);

            // perform calculations
            HugeInteger multiplicationOutput = hugeInt1.Multiplication(hugeInt2);

            // display the result
            outputLabel.Text = multiplicationOutput.ToString();

            // initiate all checkboxes to false
            isEqualCheckBox.Checked = false;
            isGreaterThanCheckBox.Checked = false;
            isGreaterThanOrEqualToCheckBox.Checked = false;
            isLessThanCheckBox.Checked = false;
            isLessThanOrEqualToCheckBox.Checked = false;
            isNotEqualCheckBox.Checked = false;
            isZeroCheckbox.Checked = false;

            // check if they are equal
            if (hugeInt1.IsEquals(hugeInt2) == true)
            {
                isEqualCheckBox.Checked = true;
                isNotEqualCheckBox.Checked = false; // opposite
                isGreaterThanOrEqualToCheckBox.Checked = true; // inclusive
                isLessThanOrEqualToCheckBox.Checked = true; // inclusive
            }

            // check if theyre not equal
            if (hugeInt1.IsNotEquals(hugeInt2) == true)
            {
                isEqualCheckBox.Checked = false;
                isNotEqualCheckBox.Checked = true; // opposite
            }

            // check if 1 > 2
            if (hugeInt1.IsGreaterThan(hugeInt2) == true)
            {
                isGreaterThanOrEqualToCheckBox.Checked = true;
                isGreaterThanCheckBox.Checked = true; // inclusive
                isLessThanCheckBox.Checked = false; // opposite
                isLessThanOrEqualToCheckBox.Checked = false; // opposite
                isEqualCheckBox.Checked = false; // opposite
                isNotEqualCheckBox.Checked = true; // inclusive
            }

            // check if 1 < 2
            if (hugeInt1.IsLessThan(hugeInt2) == true)
            {
                isLessThanCheckBox.Checked = true;
                isLessThanOrEqualToCheckBox.Checked = true; // inclusive
                isGreaterThanOrEqualToCheckBox.Checked = false; // opposite
                isGreaterThanCheckBox.Checked = false; // opposite
                isEqualCheckBox.Checked = false; // opposite
                isNotEqualCheckBox.Checked = true; // inclusive
            }

            // check if 1 >= 2
            if (hugeInt1.IsGreaterThanOrEquals(hugeInt2) == true)
            {
                isGreaterThanOrEqualToCheckBox.Checked = true;
            }

            // check if 1 <= 2
            if (hugeInt1.IsLessThanOrEquals(hugeInt2) == true)
            {
                isLessThanOrEqualToCheckBox.Checked = true;
            }

            // check if either number is = 0
            if (hugeInt1.IsZero() == true || hugeInt2.IsZero() == true)
            {
                isZeroCheckbox.Checked = true;
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
