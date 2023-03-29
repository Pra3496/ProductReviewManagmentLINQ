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




    }
}
