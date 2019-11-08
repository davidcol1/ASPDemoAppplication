﻿using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
  public class PeopleController : Controller
  {
    // GET: People
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult ListPeople()
    {
      List<PersonModel> people = new List<PersonModel>();

      people.Add(new PersonModel { FirstName = "Dave", LastName = "Colvin", Age = 35 });
      people.Add(new PersonModel { FirstName = "Tim", LastName = "Corey", Age = 44 });
      people.Add(new PersonModel { FirstName = "Sue", LastName = "Storm", Age = 32 });

      return View(people);
    }
  }
}