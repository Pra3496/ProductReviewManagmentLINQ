using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementUsingLINQ
{
    public class Management
    {
        List<ProductReviewModel> productReviewModels= new List<ProductReviewModel>();

        public void AddProductReview(List<ProductReviewModel> productList)
        {
            this.productReviewModels = productList;
            Console.WriteLine("\n\tReview is Succesfully Added");
        }

        public void DisplayProductReviewList(List<ProductReviewModel> productList)
        {
            foreach (ProductReviewModel product in productList)
            {
                Console.WriteLine(product.ProductId + " " + product.UserId + " " + product.Rating + " " + product.Review + " " + product.isLike);
            }
        }

        public void RetriveTop3Records()
        {
            var result = this.productReviewModels.OrderByDescending(p => p.Rating).Take(3);
            DisplayProductReviewList(result.ToList());
        }

        public void RetriveProductRatingGreaterThen3(List<ProductReviewModel> productReviewModels )
        {
            var result = productReviewModels.Where(p => p.Rating > 3 && (p.ProductId == 1 || p.ProductId == 4 || p.ProductId == 9));
            DisplayProductReviewList(result.ToList());
        }

        public void CountOfReview(List<ProductReviewModel> productReviewModels)
        {
            var groupOfProductId = productReviewModels.GroupBy(p => p.ProductId).Select(p => new { ProductId = p.Key, Count = p.Count() });

            foreach (var product in groupOfProductId)
            {
                Console.WriteLine("Product id: " + product.ProductId + " count: " + product.Count);
            }
        }


        public void RetrivOnlyProductIdAndReview(List<ProductReviewModel> productReviewModels)
        {
            var listOfProductId = productReviewModels.Select(p => new { p.ProductId, p.Review }).ToList();

            foreach (var product in listOfProductId)
            {
                Console.WriteLine(" Product id: " + product.ProductId + " : " + product.Review);
            }
        }

        public void SkipTop5RecordsFromProductList(List<ProductReviewModel> productReviewModels)
        {
            var result = productReviewModels.Skip(5);

            foreach (var product in result)
            {
                Console.WriteLine(" " + product.ProductId + " " + product.UserId + " " + product.Rating + " " + product.Review + " " + product.isLike);
            }
        }


    }
}
