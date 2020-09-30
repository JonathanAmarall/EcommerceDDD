using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationApp.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_Ecommerce.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {
        public readonly IInterfaceProductApp _InterfaceProductApp;
        public ProdutosController(IInterfaceProductApp interfaceProductApp)
        {
            _InterfaceProductApp = interfaceProductApp;
        }
        // GET: Produtos
        public async Task<IActionResult> Index()
        {
            var products = await _InterfaceProductApp.List();
            return View(products);
        }

        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var product = await _InterfaceProductApp.GetEntityById(id);
            return View(product);
        }

        // GET: Produtos/Create
        public async Task<IActionResult> Create()
        {

            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            try
            {
                // TODO: Add insert logic here
                await _InterfaceProductApp.AddProduct(product);

                if (product.Notifications.Any())
                {
                    foreach (var item in product.Notifications)
                    {
                        ModelState.AddModelError(item.PropertyName, item.Message);
                    }

                    return View("Edit", product);
                }

            }
            catch
            {
                return View("Edit", product);
            }

            return RedirectToAction(nameof(Index));

        }

        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _InterfaceProductApp.GetEntityById(id);
            return View(product);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product product)
        {
            try
            {
                // TODO: Add insert logic here
                await _InterfaceProductApp.UpdateProduct(product);

                if (product.Notifications.Any())
                {
                    foreach (var item in product.Notifications)
                    {
                        ModelState.AddModelError(item.PropertyName, item.Message);
                    }

                    return View("Edit", product);
                }

            }
            catch
            {
                return View("Edit", product);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _InterfaceProductApp.GetEntityById(id);
            return View(product);
        }

        // POST: Produtos/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Product product)
        {
            try
            {
                var productDelete = await _InterfaceProductApp.GetEntityById(id);

                await _InterfaceProductApp.Delete(productDelete);
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}