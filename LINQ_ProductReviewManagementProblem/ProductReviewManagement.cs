using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ProductReviewManagementProblem
{
    public class ProductReviewManagement
    {
        public void RetrieveTop3Records(List<ProductsReview> list)
        {
            //var top3=list.Where(x => x.Rating ==3).ToList();
            var top3 = (from ProductsReview in list
                        orderby ProductsReview.Rating descending
                        select ProductsReview).Take(3);
            Console.WriteLine("Top 3 Records are \n=====================================================");
            foreach (var data in top3)
            {
                Console.WriteLine($"ProductID:- {data.ProductId} \t UserID:- {data.UserId} \t Rating:- {data.Rating} " +$"\t Review:- {data.Review} \t IsLike:- {data.IsLike}");
            }
        }
    }
}
