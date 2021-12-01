﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiPrimeraAplicacionEnNetCore.Clases;
using MiPrimeraAplicacionEnNetCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MiPrimeraAplicacionEnNetCore.Controllers
{
    public class MedicamentoController : Controller
    {

        public List<SelectListItem> listaFormaFarmaceutica()
        {
            List<SelectListItem> listaFormaFarmaceutica = new List<SelectListItem>();

            using(BDHospitalContext db = new BDHospitalContext())
            {
                listaFormaFarmaceutica = (from listaFormasMarmaceuticas in db.FormaFarmaceuticas
                                          where listaFormasMarmaceuticas.Bhabilitado == 1
                                          select new SelectListItem
                                          {
                                              Text = listaFormasMarmaceuticas.Nombre,
                                              Value = listaFormasMarmaceuticas.Iidformafarmaceutica.ToString()
                                          }).ToList();
            }

            listaFormaFarmaceutica.Insert(0, new SelectListItem { Text = "Seleccionar", Value = "" });

            return listaFormaFarmaceutica;            
        }

        public IActionResult Agregar()
        {
            ViewBag.listaFormas = listaFormaFarmaceutica();
            return View();
        }
        public IActionResult Index(MedicamentoCLS omedicamentoCLS)
        {

            
            ViewBag.listaFormasFarmaceuticas = listaFormaFarmaceutica();
            List<MedicamentoCLS> listaMedicamento = new List<MedicamentoCLS>();
            using(BDHospitalContext db = new BDHospitalContext())
            {
                if (omedicamentoCLS.idFormaFarmaceutica == 0)
                {
                    listaMedicamento = (from medicamento in db.Medicamentos
                                        join formaFarmaceutica in db.FormaFarmaceuticas
                                        on medicamento.Iidformafarmaceutica equals formaFarmaceutica.Iidformafarmaceutica
                                        where medicamento.Bhabilitado == 1
                                        select new MedicamentoCLS
                                        {
                                            idMedicamento = medicamento.Iidmedicamento,
                                            nombre = medicamento.Nombre,
                                            precio = (double)medicamento.Precio,
                                            stock = (int)medicamento.Stock,
                                            formaFarmaceutica = formaFarmaceutica.Nombre
                                        }).ToList();
                } else
                {
                    listaMedicamento = (from medicamento in db.Medicamentos
                                        join formaFarmaceutica in db.FormaFarmaceuticas
                                        on medicamento.Iidformafarmaceutica equals formaFarmaceutica.Iidformafarmaceutica
                                        where medicamento.Bhabilitado == 1 && 
                                        medicamento.Iidformafarmaceutica == omedicamentoCLS.idFormaFarmaceutica
                                        select new MedicamentoCLS
                                        {
                                            idMedicamento = medicamento.Iidmedicamento,
                                            nombre = medicamento.Nombre,
                                            precio = (double)medicamento.Precio,
                                            stock = (int)medicamento.Stock,
                                            formaFarmaceutica = formaFarmaceutica.Nombre
                                        }).ToList();
                }
            }   
            return View(listaMedicamento);
        }
    }
}
