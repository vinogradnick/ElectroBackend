using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectroBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElectroBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly ElectroApiContext context;
        public RequestController(ElectroApiContext context)
        {
            this.context = context;
        }
        [HttpPost]
        public async Task<IActionResult> PostRequest(Table table)
        {
           
            switch (table.Name)
            {
                case "Fider":
                    return Ok(context.Fiders.FromSql(GenerateRequest(table)));
                case "Tp":
                    return Ok(context.Tps.FromSql(GenerateRequest(table)));
                case "Section":
                    return Ok(context.Sections.FromSql(GenerateRequest(table)));
                case "Line":
                    return Ok(context.Lines.FromSql(GenerateRequest(table)));
                case "Customer":
                    return Ok(context.Customers.FromSql(GenerateRequest(table)));
                case "Counter":
                    return Ok(context.Counter.FromSql(GenerateRequest(table)));
                case "Order":
                    return Ok(context.Orders.FromSql(GenerateRequest(table)));
                case "Workload":
                    return Ok(context.Workloads.FromSql(GenerateRequest(table)));
                default:
                    return BadRequest("Error");

            }
            

        }
        public string GenerateRequest(Table table)
        {
            string res = "SELECT * ";
            var labels = table.Labels.Where(el => el.Select).ToList();
            //for (int i = 0; i < labels.Count; i++)
            //{
            //    if (labels[i].Select)
            //    {
            //        if (i == labels.Count - 1)
            //            res += $"{labels[i].Name} ";
            //        else
            //            res += $"{labels[i].Name}, ";

            //    }
                
            //}
            res += $" FROM {table.Name}s  ";
            var boxes = table.Boxes.Where(el => el.Selection && el.Value.Length>0 && el.Operator.Length>0).ToList();
            if (boxes.Count != 0)
            {
                res += " WHERE ";
            }
            for (int i = 0; i < boxes.Count; i++)
            {
                if (boxes[i].Selection)
                {
                    if (i == boxes.Count - 1)
                        res += $" {boxes[i].Name} {boxes[i].Operator} {boxes[i].Value} ";
                    else
                        res += $" {boxes[i].Name} {boxes[i].Operator} {boxes[i].Value} AND ";

                }
            }
           
            return res;
        }
    }
}