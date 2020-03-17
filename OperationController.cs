﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatriceAPI.Controllers
{
    using DTO;

    [Route("api/operations")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        private static List<OperationDTO> operations = new List<OperationDTO>();

        [HttpGet]
        [Route("")]
        public List<OperationDTO> findAll()
        {
            List<OperationDTO> result = new List<OperationDTO>();
            foreach (OperationDTO operation in operations)
            {
                if (operation != null)
                {
                    result.Add(operation);
                }
            }
            return result;
        }

        [HttpPost]
        [Route("")]
        public OperationDTO save([FromBody] OperationDTO data)
        {
            data.Id = operations.Count;
            operations.Add(data);
            return data;
        }

        [HttpGet]
        [Route("{id}")]
        public OperationDTO findById(int id)
        {
            return operations[id];
        }

        [HttpDelete]
        [Route("{id}")]
        public void delete(int id)
        {
            operations[id] = null;
        }

        [HttpPut]
        [Route("{id}")]
        public OperationDTO update(int id, [FromBody] OperationDTO data)
        {
            data.Id = id;
            operations[id] = data;
            return data;
        }
        [HttpGet]
        [Route("nom/{nom}")]
        public List<OperationDTO> findByNom(string nom)
        {
            return operations.Where(op => op.nom == nom).ToList();
        }
        [HttpGet]
        [Route("valeur/{valeur}")]
        public List<OperationDTO> FindByValeur(string valeur)
        {
            List<OperationDTO> result = new List<OperationDTO>();
            foreach (OperationDTO op in operations)
            {
                if (op.Valeur == valeur)
                {
                    result.Add(op);
                }
            }
            return result;
        }
    }
}