using Microsoft.AspNetCore.Mvc;
using MvcBasicSample.Models;

namespace MvcBasicSample.Controllers;

//URLのHelloに対応する要求を受け取るController
public class HelloController : Controller {

    // ../Hello/Indexで呼び出されるAction
    public IActionResult Index() {
        //Productを複数まとめる一覧を作る
        var products = new List<Product> {
            new Product {
                Name = "ハンバーガー",
                Price = 500
            },
            new Product {
                Name = "紅茶",
                Price = 450
            },
            new Product {
                Name = "ジュース",
                Price = 300
            },
            new Product {
                Name = "コーラ",
                Price = 200
            }
        };

        return View(products);
    }
}
