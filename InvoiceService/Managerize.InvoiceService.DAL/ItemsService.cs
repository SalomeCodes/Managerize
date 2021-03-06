﻿using Managerize.InvoiceService.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Managerize.InvoiceService.DAL
{
    public class ItemsService
    {
        private readonly InvoiceContext _invoiceContext;

        public ItemsService(InvoiceContext context) => _invoiceContext = context;

        public List<Item> ReadItems()
        {
            return _invoiceContext.Items.ToList();
        }

        public void AddItem(Item item)
        {
            _invoiceContext.Add(item);
            _invoiceContext.SaveChanges();
        }

        public void UpdateItem(Item item)
        {
            var itemToUpdate = _invoiceContext.Items.Single(i => i.Id == 1);
            itemToUpdate.Description = "update to save";

            _invoiceContext.Database.ExecuteSqlRaw("UPDATE Items SET Name = 'conflict update' WHERE Id = 1");

            try
            {
                _invoiceContext.SaveChanges();
            }
            catch(DbUpdateConcurrencyException ex)
            {

            }
        }
    }
}
