using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Managerize.InvoiceService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Invoice> Get()
        {
            return new List<Invoice>()
            {
                new Invoice()
                {
                    Id = 1,
                    TotalPrice = 3900,
                    CreationDate = DateTime.Now,
                    DatePayed = null,
                    DateSent = null,
                    IsPayed = false,
                    PayedAmount = 0,
                    Customer = new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bob",
                        Prefix = null,
                        Surname = "Smith",
                        Email = "Bob.Smith@email.com",
                        HouseNumber = "42",
                        PhoneNumber = "+57-893751824",
                        Place = "Newark",
                        Street = "Mead St",
                        ZipCode = "NJ 07106"
                    },
                    InvoiceLines = new List<InvoiceLine>()
                    {
                        new InvoiceLine() { 
                            Id = 1, 
                            Amount = 10, 
                            Item = new Item()
                            {
                                Id = 1, 
                                Name = "Worcester System Filter",
                                Description = "Worcester greenstar magnetic system filter",
                                Price = 190
                            }
                        },
                        new InvoiceLine() {
                            Id = 2,
                            Amount = 2,
                            Item = new Item()
                            {
                                Id = 2,
                                Name = "Sink",
                                Description = "Toto sink",
                                Price = 500
                            }
                        }
                    }
                },
                new Invoice()
                {
                    Id = 1,
                    TotalPrice = 3900,
                    CreationDate = DateTime.Now,
                    DatePayed = null,
                    DateSent = null,
                    IsPayed = false,
                    PayedAmount = 0,
                    Customer = new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bob",
                        Prefix = null,
                        Surname = "Smith",
                        Email = "Bob.Smith@email.com",
                        HouseNumber = "42",
                        PhoneNumber = "+57-893751824",
                        Place = "Newark",
                        Street = "Mead St",
                        ZipCode = "NJ 07106"
                    },
                    InvoiceLines = new List<InvoiceLine>()
                    {
                        new InvoiceLine() {
                            Id = 1,
                            Amount = 10,
                            Item = new Item()
                            {
                                Id = 1,
                                Name = "Worcester System Filter",
                                Description = "Worcester greenstar magnetic system filter",
                                Price = 190
                            }
                        },
                        new InvoiceLine() {
                            Id = 2,
                            Amount = 2,
                            Item = new Item()
                            {
                                Id = 2,
                                Name = "Sink",
                                Description = "Toto sink",
                                Price = 500
                            }
                        }
                    }
                },
                new Invoice()
                {
                    Id = 1,
                    TotalPrice = 3900,
                    CreationDate = DateTime.Now,
                    DatePayed = null,
                    DateSent = null,
                    IsPayed = false,
                    PayedAmount = 0,
                    Customer = new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bob",
                        Prefix = null,
                        Surname = "Smith",
                        Email = "Bob.Smith@email.com",
                        HouseNumber = "42",
                        PhoneNumber = "+57-893751824",
                        Place = "Newark",
                        Street = "Mead St",
                        ZipCode = "NJ 07106"
                    },
                    InvoiceLines = new List<InvoiceLine>()
                    {
                        new InvoiceLine() {
                            Id = 1,
                            Amount = 10,
                            Item = new Item()
                            {
                                Id = 1,
                                Name = "Worcester System Filter",
                                Description = "Worcester greenstar magnetic system filter",
                                Price = 190
                            }
                        },
                        new InvoiceLine() {
                            Id = 2,
                            Amount = 2,
                            Item = new Item()
                            {
                                Id = 2,
                                Name = "Sink",
                                Description = "Toto sink",
                                Price = 500
                            }
                        }
                    }
                },
                new Invoice()
                {
                    Id = 1,
                    TotalPrice = 3900,
                    CreationDate = DateTime.Now,
                    DatePayed = null,
                    DateSent = null,
                    IsPayed = false,
                    PayedAmount = 0,
                    Customer = new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bob",
                        Prefix = null,
                        Surname = "Smith",
                        Email = "Bob.Smith@email.com",
                        HouseNumber = "42",
                        PhoneNumber = "+57-893751824",
                        Place = "Newark",
                        Street = "Mead St",
                        ZipCode = "NJ 07106"
                    },
                    InvoiceLines = new List<InvoiceLine>()
                    {
                        new InvoiceLine() {
                            Id = 1,
                            Amount = 10,
                            Item = new Item()
                            {
                                Id = 1,
                                Name = "Worcester System Filter",
                                Description = "Worcester greenstar magnetic system filter",
                                Price = 190
                            }
                        },
                        new InvoiceLine() {
                            Id = 2,
                            Amount = 2,
                            Item = new Item()
                            {
                                Id = 2,
                                Name = "Sink",
                                Description = "Toto sink",
                                Price = 500
                            }
                        }
                    }
                },new Invoice()
                {
                    Id = 1,
                    TotalPrice = 3900,
                    CreationDate = DateTime.Now,
                    DatePayed = null,
                    DateSent = null,
                    IsPayed = false,
                    PayedAmount = 0,
                    Customer = new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bob",
                        Prefix = null,
                        Surname = "Smith",
                        Email = "Bob.Smith@email.com",
                        HouseNumber = "42",
                        PhoneNumber = "+57-893751824",
                        Place = "Newark",
                        Street = "Mead St",
                        ZipCode = "NJ 07106"
                    },
                    InvoiceLines = new List<InvoiceLine>()
                    {
                        new InvoiceLine() {
                            Id = 1,
                            Amount = 10,
                            Item = new Item()
                            {
                                Id = 1,
                                Name = "Worcester System Filter",
                                Description = "Worcester greenstar magnetic system filter",
                                Price = 190
                            }
                        },
                        new InvoiceLine() {
                            Id = 2,
                            Amount = 2,
                            Item = new Item()
                            {
                                Id = 2,
                                Name = "Sink",
                                Description = "Toto sink",
                                Price = 500
                            }
                        }
                    }
                },
                new Invoice()
                {
                    Id = 1,
                    TotalPrice = 3900,
                    CreationDate = DateTime.Now,
                    DatePayed = null,
                    DateSent = null,
                    IsPayed = false,
                    PayedAmount = 0,
                    Customer = new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bob",
                        Prefix = null,
                        Surname = "Smith",
                        Email = "Bob.Smith@email.com",
                        HouseNumber = "42",
                        PhoneNumber = "+57-893751824",
                        Place = "Newark",
                        Street = "Mead St",
                        ZipCode = "NJ 07106"
                    },
                    InvoiceLines = new List<InvoiceLine>()
                    {
                        new InvoiceLine() {
                            Id = 1,
                            Amount = 10,
                            Item = new Item()
                            {
                                Id = 1,
                                Name = "Worcester System Filter",
                                Description = "Worcester greenstar magnetic system filter",
                                Price = 190
                            }
                        },
                        new InvoiceLine() {
                            Id = 2,
                            Amount = 2,
                            Item = new Item()
                            {
                                Id = 2,
                                Name = "Sink",
                                Description = "Toto sink",
                                Price = 500
                            }
                        }
                    }
                },
                new Invoice()
                {
                    Id = 1,
                    TotalPrice = 3900,
                    CreationDate = DateTime.Now,
                    DatePayed = null,
                    DateSent = null,
                    IsPayed = false,
                    PayedAmount = 0,
                    Customer = new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bob",
                        Prefix = null,
                        Surname = "Smith",
                        Email = "Bob.Smith@email.com",
                        HouseNumber = "42",
                        PhoneNumber = "+57-893751824",
                        Place = "Newark",
                        Street = "Mead St",
                        ZipCode = "NJ 07106"
                    },
                    InvoiceLines = new List<InvoiceLine>()
                    {
                        new InvoiceLine() {
                            Id = 1,
                            Amount = 10,
                            Item = new Item()
                            {
                                Id = 1,
                                Name = "Worcester System Filter",
                                Description = "Worcester greenstar magnetic system filter",
                                Price = 190
                            }
                        },
                        new InvoiceLine() {
                            Id = 2,
                            Amount = 2,
                            Item = new Item()
                            {
                                Id = 2,
                                Name = "Sink",
                                Description = "Toto sink",
                                Price = 500
                            }
                        }
                    }
                }
            };
        }
    }
}