using BlazorFormDesigner.BusinessLogic.Interfaces;
using BlazorFormDesigner.BusinessLogic.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorFormDesigner.BusinessLogic.Services
{
    public class FormService
    {
        private readonly IFormRepository FormRepository;

        public FormService(IFormRepository formRepository)
        {
            FormRepository = formRepository;
        }

        public async Task<List<Form>> GetAll()
        {
            return await FormRepository.GetAll();
        }

        public async Task<Form> Create(Form form)
        {
            return await FormRepository.Create(form);
        }
    }
}
