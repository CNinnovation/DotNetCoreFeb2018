using System;
using System.Collections.Generic;
using System.Text;

namespace DISample
{
    public class HomeController
    {
        private readonly IHelloService _helloService;
        public HomeController(IHelloService helloService)
        {
            _helloService = helloService;
        }
        public string Index(string name)
        {
            return _helloService.Hello(name);
        }
    }
}
