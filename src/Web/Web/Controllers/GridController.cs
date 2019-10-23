using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
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

        protected IActionResult ShowCell(
            CellColor color,
            MusicalNote note,
            [CallerMemberName] string caller = "") {

            ViewData["Color"] = color.ToString().ToLower();
            ViewData["Note"] = note;
            ViewData["Code"] = caller;

            return View("MusicalCell");
        }

        [HttpGet("A1")]
        public IActionResult A1() {
            return ShowCell(CellColor.Red, MusicalNote.Do);
        }

        [HttpGet("B1")]
        public IActionResult B1() {
            return ShowCell(CellColor.Grey, MusicalNote.Sol);
        }

        [HttpGet("C1")]
        public IActionResult C1() {
            return ShowCell(CellColor.Grey, MusicalNote.Do);
        }

        [HttpGet("D1")]
        public IActionResult D1() {
            return ShowCell(CellColor.Grey, MusicalNote.Mi);
        }

        [HttpGet("E1")]
        public IActionResult E1() {
            return ShowCell(CellColor.Red, MusicalNote.Do);
        }


        [HttpGet("A2")]
        public IActionResult A2() {
            return ShowCell(CellColor.Grey, MusicalNote.Mi);
        }

        [HttpGet("B2")]
        public IActionResult B2() {
            return ShowCell(CellColor.Yellow, MusicalNote.La);
        }

        [HttpGet("C2")]
        public IActionResult C2() {
            return ShowCell(CellColor.Yellow, MusicalNote.Sol);
        }

        [HttpGet("D2")]
        public IActionResult D2() {
            return ShowCell(CellColor.Yellow, MusicalNote.Fa);
        }

        [HttpGet("E2")]
        public IActionResult E2() {
            return ShowCell(CellColor.Grey, MusicalNote.Fa);
        }


        [HttpGet("A3")]
        public IActionResult A3() {
            return ShowCell(CellColor.Grey, MusicalNote.Do);
        }

        [HttpGet("B3")]
        public IActionResult B3() {
            return ShowCell(CellColor.Yellow, MusicalNote.Si);
        }

        [HttpGet("C3")]
        public IActionResult C3() {
            return ShowCell(CellColor.Grey, MusicalNote.Do);
        }

        [HttpGet("D3")]
        public IActionResult D3() {
            return ShowCell(CellColor.Yellow, MusicalNote.Mi);
        }

        [HttpGet("E3")]
        public IActionResult E3() {
            return ShowCell(CellColor.Grey, MusicalNote.Do);
        }


        [HttpGet("A4")]
        public IActionResult A4() {
            return ShowCell(CellColor.Red, MusicalNote.Sol);
        }

        [HttpGet("B4")]
        public IActionResult B4() {
            return ShowCell(CellColor.Red, MusicalNote.Re);
        }

        [HttpGet("C4")]
        public IActionResult C4() {
            return ShowCell(CellColor.Yellow, MusicalNote.Do);
        }

        [HttpGet("D4")]
        public IActionResult D4() {
            return ShowCell(CellColor.Yellow, MusicalNote.Re);
        }

        [HttpGet("E4")]
        public IActionResult E4() {
            return ShowCell(CellColor.Grey, MusicalNote.Sol);
        }


        [HttpGet("A5")]
        public IActionResult A5() {
            return ShowCell(CellColor.Grey, MusicalNote.Do);
        }

        [HttpGet("B5")]
        public IActionResult B5() {
            return ShowCell(CellColor.Red, MusicalNote.Mi);
        }

        [HttpGet("C5")]
        public IActionResult C5() {
            return ShowCell(CellColor.Grey, MusicalNote.Fa);
        }

        [HttpGet("D5")]
        public IActionResult D5() {
            return ShowCell(CellColor.Grey, MusicalNote.Fa);
        }

        [HttpGet("E5")]
        public IActionResult E5() {
            return ShowCell(CellColor.Red, MusicalNote.Sol);
        }

    }
}
