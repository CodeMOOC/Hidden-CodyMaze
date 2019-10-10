using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;

namespace Web.Controllers {

    [Route("")]
    public class GridController : Controller {
        private readonly ILogger<GridController> _logger;

        public GridController(ILogger<GridController> logger) {
            _logger = logger;
        }

        [HttpGet("A1")]
        public IActionResult A1() {
            ViewData["Code"] = "A1";
            return View("Red");
        }

        [HttpGet("B1")]
        public IActionResult B1() {
            ViewData["Code"] = "B1";
            return View("Gray");
        }

        [HttpGet("C1")]
        public IActionResult C1() {
            ViewData["Code"] = "C1";
            return View("Gray");
        }

        [HttpGet("D1")]
        public IActionResult D1() {
            ViewData["Code"] = "D1";
            return View("Gray");
        }

        [HttpGet("E1")]
        public IActionResult E1() {
            ViewData["Code"] = "E1";
            return View("Red");
        }


        [HttpGet("A2")]
        public IActionResult A2() {
            ViewData["Code"] = "A2";
            return View("Gray");
        }

        [HttpGet("B2")]
        public IActionResult B2() {
            ViewData["Code"] = "B2";
            return View("Yellow");
        }

        [HttpGet("C2")]
        public IActionResult C2() {
            ViewData["Code"] = "C2";
            return View("Gray");
        }

        [HttpGet("D2")]
        public IActionResult D2() {
            ViewData["Code"] = "D2";
            return View("Yellow");
        }

        [HttpGet("E2")]
        public IActionResult E2() {
            ViewData["Code"] = "E2";
            return View("Gray");
        }


        [HttpGet("A3")]
        public IActionResult A3() {
            ViewData["Code"] = "A3";
            return View("Gray");
        }

        [HttpGet("B3")]
        public IActionResult B3() {
            ViewData["Code"] = "B3";
            return View("Yellow");
        }

        [HttpGet("C3")]
        public IActionResult C3() {
            ViewData["Code"] = "C3";
            return View("Red");
        }

        [HttpGet("D3")]
        public IActionResult D3() {
            ViewData["Code"] = "D3";
            return View("Yellow");
        }

        [HttpGet("E3")]
        public IActionResult E3() {
            ViewData["Code"] = "E3";
            return View("Gray");
        }


        [HttpGet("A4")]
        public IActionResult A4() {
            ViewData["Code"] = "A4";
            return View("Red");
        }

        [HttpGet("B4")]
        public IActionResult B4() {
            ViewData["Code"] = "B4";
            return View("Gray");
        }

        [HttpGet("C4")]
        public IActionResult C4() {
            ViewData["Code"] = "C4";
            return View("Red");
        }

        [HttpGet("D4")]
        public IActionResult D4() {
            ViewData["Code"] = "D4";
            return View("Gray");
        }

        [HttpGet("E4")]
        public IActionResult E4() {
            ViewData["Code"] = "E4";
            return View("Red");
        }


        [HttpGet("A5")]
        public IActionResult A5() {
            ViewData["Code"] = "A5";
            return View("Gray");
        }

        [HttpGet("B5")]
        public IActionResult B5() {
            ViewData["Code"] = "B5";
            return View("Gray");
        }

        [HttpGet("C5")]
        public IActionResult C5() {
            ViewData["Code"] = "C5";
            return View("Yellow");
        }

        [HttpGet("D5")]
        public IActionResult D5() {
            ViewData["Code"] = "D5";
            return View("Red");
        }

        [HttpGet("E5")]
        public IActionResult E5() {
            ViewData["Code"] = "E5";
            return View("Red");
        }

    }
}
