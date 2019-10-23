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
            string audioSuffix = "",
            [CallerMemberName] string caller = "") {

            ViewData["Color"] = color.ToString().ToLower();
            ViewData["Note"] = note;
            ViewData["Code"] = caller;
            ViewData["NoteAudioSuffix"] = audioSuffix;

            return View("MusicalCell");
        }

        [HttpGet("A1")]
        public IActionResult A1() {
            return ShowCell(CellColor.Red, MusicalNote.Do, "1");
        }

        [HttpGet("B1")]
        public IActionResult B1() {
            return ShowCell(CellColor.Grey, MusicalNote.Sol, "1");
        }

        [HttpGet("C1")]
        public IActionResult C1() {
            return ShowCell(CellColor.Grey, MusicalNote.Do, "1");
        }

        [HttpGet("D1")]
        public IActionResult D1() {
            return ShowCell(CellColor.Grey, MusicalNote.Mi, "2");
        }

        [HttpGet("E1")]
        public IActionResult E1() {
            return ShowCell(CellColor.Red, MusicalNote.Do, "2");
        }


        [HttpGet("A2")]
        public IActionResult A2() {
            return ShowCell(CellColor.Grey, MusicalNote.Mi, "2");
        }

        [HttpGet("B2")]
        public IActionResult B2() {
            return ShowCell(CellColor.Yellow, MusicalNote.La, "1");
        }

        [HttpGet("C2")]
        public IActionResult C2() {
            return ShowCell(CellColor.Yellow, MusicalNote.Sol, "1");
        }

        [HttpGet("D2")]
        public IActionResult D2() {
            return ShowCell(CellColor.Yellow, MusicalNote.Fa, "1");
        }

        [HttpGet("E2")]
        public IActionResult E2() {
            return ShowCell(CellColor.Grey, MusicalNote.Fa, "1");
        }


        [HttpGet("A3")]
        public IActionResult A3() {
            return ShowCell(CellColor.Grey, MusicalNote.Do, "1");
        }

        [HttpGet("B3")]
        public IActionResult B3() {
            return ShowCell(CellColor.Yellow, MusicalNote.Si, "1");
        }

        [HttpGet("C3")]
        public IActionResult C3() {
            return ShowCell(CellColor.Grey, MusicalNote.Do, "2");
        }

        [HttpGet("D3")]
        public IActionResult D3() {
            return ShowCell(CellColor.Yellow, MusicalNote.Mi, "1");
        }

        [HttpGet("E3")]
        public IActionResult E3() {
            return ShowCell(CellColor.Grey, MusicalNote.Do, "1");
        }


        [HttpGet("A4")]
        public IActionResult A4() {
            return ShowCell(CellColor.Red, MusicalNote.Sol, "1");
        }

        [HttpGet("B4")]
        public IActionResult B4() {
            return ShowCell(CellColor.Red, MusicalNote.Re, "2");
        }

        [HttpGet("C4")]
        public IActionResult C4() {
            return ShowCell(CellColor.Yellow, MusicalNote.Do, "2");
        }

        [HttpGet("D4")]
        public IActionResult D4() {
            return ShowCell(CellColor.Yellow, MusicalNote.Re, "2");
        }

        [HttpGet("E4")]
        public IActionResult E4() {
            return ShowCell(CellColor.Grey, MusicalNote.Sol, "2");
        }


        [HttpGet("A5")]
        public IActionResult A5() {
            return ShowCell(CellColor.Grey, MusicalNote.Do, "1");
        }

        [HttpGet("B5")]
        public IActionResult B5() {
            return ShowCell(CellColor.Red, MusicalNote.Mi, "2");
        }

        [HttpGet("C5")]
        public IActionResult C5() {
            return ShowCell(CellColor.Grey, MusicalNote.Fa, "2");
        }

        [HttpGet("D5")]
        public IActionResult D5() {
            return ShowCell(CellColor.Grey, MusicalNote.Fa, "2");
        }

        [HttpGet("E5")]
        public IActionResult E5() {
            return ShowCell(CellColor.Red, MusicalNote.Sol, "2");
        }

    }
}
