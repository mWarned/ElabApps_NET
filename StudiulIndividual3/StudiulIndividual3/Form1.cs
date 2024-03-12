using StudiulIndividual3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudiulIndividual3
{
    public partial class Form1 : Form
    {
        int CURRENT_RATING = 0;
        List<Review> currentRatings;
        public Form1()
        {
            InitializeComponent();
            currentRatings = new List<Review>();
        }

        private void pb_str5_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            pb_str3.Image = Resources.yellow_star;
            pb_str4.Image = Resources.yellow_star;
            pb_str5.Image = Resources.yellow_star;
            CURRENT_RATING = 5;
        }

        private void pb_str4_Click(object sender, EventArgs e)
        {
            //change yellow star to white
            pb_str5.Image = Resources.white_star;

            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            pb_str3.Image = Resources.yellow_star;
            pb_str4.Image = Resources.yellow_star;
            CURRENT_RATING = 4;
        }

        private void pb_str3_Click(object sender, EventArgs e)
        {
            //change yellow stars to white
            pb_str4.Image = Resources.white_star;
            pb_str5.Image = Resources.white_star;

            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            pb_str3.Image = Resources.yellow_star;
            CURRENT_RATING = 3;
        }

        private void pb_str2_Click(object sender, EventArgs e)
        {
            //change yellow stars to white
            pb_str3.Image = Resources.white_star;
            pb_str4.Image = Resources.white_star;
            pb_str5.Image = Resources.white_star;

            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            CURRENT_RATING = 2;
        }

        private void pb_str1_Click(object sender, EventArgs e)
        {
            //change yellow stars to white
            pb_str2.Image = Resources.white_star;
            pb_str3.Image = Resources.white_star;
            pb_str4.Image = Resources.white_star;
            pb_str5.Image = Resources.white_star;

            pb_str1.Image = Resources.yellow_star;
            CURRENT_RATING = 1;
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            Review review = new Review(txtReview.Text, CURRENT_RATING);
            currentRatings.Add(review);
            UpdateReviewList();

            txtReview.Text = "";
            pb_str1.Image = Resources.white_star;
            pb_str2.Image = Resources.white_star;
            pb_str3.Image = Resources.white_star;
            pb_str4.Image = Resources.white_star;
            pb_str5.Image = Resources.white_star;
            CURRENT_RATING = 0;
        }

        private void UpdateReviewList()
        {
            listReview.Items.Clear();

            foreach (Review review in currentRatings)
            {
                listReview.Items.Add($"Rating: {review.getRating()} \r\n");
                listReview.Items.Add($"{review.getReview()} \r\n");
                listReview.Items.Add($"\t");
            }
        }
    }
}
