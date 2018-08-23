using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Sample.Application.ViewModels.Listings;
using Sample.Domain.Entities;

namespace Sample.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Motorista")]
    public class MotoristaController : ApiController
    {
        [HttpGet, Route("get-motorista-listagem")]
        public IActionResult getListagem()
        {
            var vm = this.CreateFixedListingData;
            return Success(vm);
        }

        [HttpGet, Route("get-motorista/{idMotorista}")]
        public IActionResult getMotorista(string idMotorista)
        {
            var parsedId = new Guid(idMotorista);
            var found = this.CreateFixedFormData.FirstOrDefault(a => a.Id == parsedId);

            return Success(found);
        }

        #region ActionResults
        protected new IActionResult Success(object result)
        {
            return Ok(new
            {
                success = true,
                data = result
            });
        }

        protected new IActionResult Failed(Dictionary<string, string> errors)
        {
            return BadRequest(ModelState);
        }

        private ModelStateDictionary Create(Dictionary<string, string> errors)
        {
            return new ModelStateDictionary();
        }
        #endregion

        #region Fixed Data
        private List<MotoristaListagemViewModel> CreateFixedListingData
        {
            get
            {
                var vms = new List<MotoristaListagemViewModel> {
                    new MotoristaListagemViewModel
                    {
                        ClasseCarteira = new List<string>{ "A", "B", "C" },
                        Nome= "Gustavo Cruz",
                        IdMotorista = "08d6063d-52fe-8e6c-2831-1644e29cc559",
                        NumeroCarteiraMotorista = "1123334",
                        PlacaVeiculo = "FOZ1234",
                        ProblemasCadastrais = false
                    },
                    new MotoristaListagemViewModel
                    {
                        ClasseCarteira = new List<string>{ "B", "D" },
                        Nome= "João Silva",
                        IdMotorista = "08d6063a-125c-ca98-5296-d243e34e4213",
                        NumeroCarteiraMotorista = "4443215",
                        PlacaVeiculo = "SIS8674",
                        ProblemasCadastrais = false
                    },
                    new MotoristaListagemViewModel
                    {
                        ClasseCarteira = new List<string>{ "E" },
                        Nome= "Tiago Lee",
                        IdMotorista = "08d60640-6193-552c-8d0c-851c81bc1af7",
                        NumeroCarteiraMotorista = "85613247",
                        PlacaVeiculo = "KEO4763",
                        ProblemasCadastrais = false
                    },
                    new MotoristaListagemViewModel
                    {
                        ClasseCarteira = new List<string>{ "A", "B", "C", "D" },
                        Nome= "Fernando Feijó",
                        IdMotorista = "08d60640-a654-b5ef-dc36-dffc9a368103",
                        NumeroCarteiraMotorista = "758433168",
                        PlacaVeiculo = "QZI5429",
                        ProblemasCadastrais = false
                    },
                    new MotoristaListagemViewModel
                    {
                        ClasseCarteira = new List<string>{ "A" },
                        Nome= "Jean Dubois",
                        IdMotorista = "08d60640-c35f-96a4-5f94-b535b8962308",
                        NumeroCarteiraMotorista = "759845612",
                        PlacaVeiculo = "SOX4444",
                        ProblemasCadastrais = false
                    }
                };


                return vms;
            }
        }

        private List<Motorista> CreateFixedFormData
        {
            get
            {
                var vms = new List<Motorista>
                {
                    new Motorista
                    {
                        ClasseCarteira = new List<string>{ "A", "B", "C" },
                        Nome= "Gustavo Cruz",
                        Id = new Guid("08d6063d-52fe-8e6c-2831-1644e29cc559"),
                        NumeroCarteiraMotorista = "1123334",
                        DataValidadeCarteira = new DateTime(2020,01,01),
                        VeiculoPrincipal = new Veiculo
                        {
                            ClasseRequerida = "B",
                            Id = Guid.NewGuid(),
                            Placa = "FOZ1234"
                        }
                        //ProblemasCadastrais = false
                    },
                    new Motorista
                    {
                        ClasseCarteira = new List<string>{ "B", "D" },
                        Nome= "João Silva",
                        Id = new Guid("08d6063a-125c-ca98-5296-d243e34e4213"),
                        NumeroCarteiraMotorista = "4443215",
                        DataValidadeCarteira = new DateTime(2023,12,31),
                        VeiculoPrincipal = new Veiculo
                        {
                            ClasseRequerida = "D",
                            Id = Guid.NewGuid(),
                            Placa = "SIS8674"
                        }
                        //ProblemasCadastrais = false
                    },
                    new Motorista
                    {
                        ClasseCarteira = new List<string>{ "E" },
                        Nome= "Tiago Lee",
                        Id = new Guid("08d60640-6193-552c-8d0c-851c81bc1af7"),
                        NumeroCarteiraMotorista = "85613247",
                        DataValidadeCarteira = new DateTime(2021,5,14),
                        VeiculoPrincipal = new Veiculo
                        {
                            ClasseRequerida = "E",
                            Id = Guid.NewGuid(),
                            Placa = "KEO4763"
                        }
                        //ProblemasCadastrais = false
                    },
                    new Motorista
                    {
                        ClasseCarteira = new List<string>{ "A", "B", "C", "D" },
                        Nome= "Fernando Feijó",
                        Id = new Guid("08d60640-a654-b5ef-dc36-dffc9a368103"),
                        NumeroCarteiraMotorista = "758433168",
                        DataValidadeCarteira = new DateTime(2020,7,15),
                        VeiculoPrincipal = new Veiculo
                        {
                            ClasseRequerida = "C",
                            Id = Guid.NewGuid(),
                            Placa = "QZI5429"
                        }
                        //ProblemasCadastrais = false
                    },
                    new Motorista
                    {
                        ClasseCarteira = new List<string>{ "A" },
                        Nome= "Jean Dubois",
                        Id = new Guid("08d60640-c35f-96a4-5f94-b535b8962308"),
                        NumeroCarteiraMotorista = "759845612",
                        DataValidadeCarteira = new DateTime(2019,9,01),
                        VeiculoPrincipal = new Veiculo
                        {
                            ClasseRequerida = "A",
                            Id = Guid.NewGuid(),
                            Placa = "SOX4444"
                        }
                        //ProblemasCadastrais = false
                    }
                };

                return vms;
            }
        }
        #endregion
    }
}