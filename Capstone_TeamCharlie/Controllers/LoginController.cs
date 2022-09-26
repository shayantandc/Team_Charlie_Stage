﻿using Login.Commands;
using Login.Models;
using Login.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Login.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IMediator _mediatr;



        public LoginController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }
        // GET: api/<LoginController>
        [HttpGet("{id}")]
        //[Route("getUsersById")]
        public async Task<EcomLogin> Get(int id)
        {
            return await _mediatr.Send(new GetUsersbyId()
            {
                Id = id
            });
        }

        //// GET api/<LoginController>/5
        [HttpGet]
        //[Route("getUsers")]
        public async Task<IEnumerable<EcomLogin>> getAllUsers()
        {
            return await _mediatr.Send(new GetAllUsers());
        }

        // POST api/<LoginController>
        [HttpPost]
        public async Task<EcomLogin> Post(string pass,string email)
        {
            return await _mediatr.Send(new Register()
            {
                Password = pass,
                Emailid = email
            }
                );
        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
