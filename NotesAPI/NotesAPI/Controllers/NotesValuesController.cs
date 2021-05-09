using Microsoft.AspNetCore.Mvc;
using NotesAPI.DTO;
using NotesAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NotesAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NotesValuesController : ControllerBase
    {
        private readonly INoteService _noteService;
        public NotesValuesController(INoteService service)
        {
            _noteService = service;
        }
        
        [HttpGet]
        public IEnumerable<NoteDTO> GetAllNotes()
        {
            IEnumerable<NoteDTO> notes = _noteService.GetAllNotes();
            return notes;
        }

        // GET api/<NotesValuesController>/5
        [HttpGet("{id}")]
        public async Task<NoteDTO> GetNote(int id)
        {
            NoteDTO note = await _noteService.GetNote(id);
            return note;
        }

        // POST api/<NotesValuesController>
        [HttpPost]
        public async Task CreateNote([FromBody] CreateNoteDTO value)
        {
            await _noteService.CreateNote(value);
        }

        // PUT api/<NotesValuesController>/5
        [HttpPut("{value}")]
        public async Task UpdateNote( [FromBody] NoteDTO value)
        {
            await _noteService.UpdateNote(value);
        }

        // DELETE api/<NotesValuesController>/5
        [HttpDelete("{id}")]
        public async Task DeleteNote(int id)
        {
            await _noteService.DeleteNote(id);
        }
    }
}
