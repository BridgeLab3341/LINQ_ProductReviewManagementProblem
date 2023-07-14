using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        public void RetrieveRecordsGreaterThan3Ratings(List<ProductsReview> list)
        {
            var records=list.Where(x=> x.Rating > 4 && x.ProductId ==1 || x.ProductId ==4 || x.ProductId ==9);
            //var records = (from ProductsReview in list
            //               where ProductsReview.Rating > 3 && ProductsReview.ProductId == 1 || ProductsReview.ProductId == 4 || ProductsReview.ProductId == 9
            //               select ProductsReview);
            Console.WriteLine("Records Which are Greater than Rating 3 and ProductId 1, 4 and 9");
            Console.WriteLine("==================================================================");
            foreach(var data in records)
            {
                Console.WriteLine($"ProductID:- {data.ProductId} \t UserID:- {data.UserId} \t Rating:- {data.Rating} " + $"\t Review:- {data.Review} \t IsLike:- {data.IsLike}");
            }
        }
    }
}
