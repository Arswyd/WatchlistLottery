using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchlistLibrary
{
    public static class InputValidation
    {
        public static bool ValidateFilters(string txtTitle, string txtMinScore, string txtMaxScore, string txtMinDate, string txtMaxDate)
        {
            double minScore;
            double maxScore;
            int minDate;
            int maxDate;

            bool isDoubleMinScore = double.TryParse(txtMinScore, out minScore);
            bool isDoubleMaxScore = double.TryParse(txtMaxScore, out maxScore);
            bool isIntMinDate = int.TryParse(txtMinDate, out minDate);
            bool isIntMaxDate = int.TryParse(txtMaxDate, out maxDate);

            if (!String.IsNullOrWhiteSpace(txtTitle) && (txtTitle.Contains("\"") || txtTitle.Contains(";")))
            {
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(txtMinScore) && (txtMinScore.Contains('.') || !isDoubleMinScore))
            {
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(txtMinScore) && minScore <= 0)
            {
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(txtMaxScore) && (txtMaxScore.Contains('.') || !isDoubleMaxScore))
            {
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(txtMaxScore) && (maxScore > 10.0 || maxScore < 0))
            {
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(txtMinDate) && !isIntMinDate)
            {
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(txtMinDate) && minDate <= 0)
            {
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(txtMaxDate) && !isIntMaxDate)
            {
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(txtMaxDate) && (maxDate > DateTime.Now.Year || maxDate < 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidateTitle(string txtTitle)
        {
            if (!String.IsNullOrWhiteSpace(txtTitle) && (txtTitle.Contains("\"") || txtTitle.Contains(";")))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidateScore(string txtScore)
        {
            double score;

            bool isDoubleScore = double.TryParse(txtScore, out score);

            if (!String.IsNullOrWhiteSpace(txtScore) && (txtScore.Contains('.') || !isDoubleScore))
            {
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(txtScore) && (score > 10.0 || score < 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidateDate(string txtDate)
        {
            int date;

            bool isIntDate = int.TryParse(txtDate, out date);

            if (!String.IsNullOrWhiteSpace(txtDate) && !isIntDate)
            {
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(txtDate) && (date <= 0 || date > DateTime.Now.Year))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidateCategory(string txtCategory)
        {
            if (!String.IsNullOrWhiteSpace(txtCategory) && (txtCategory.Contains("\"") || txtCategory.Contains(";")))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
