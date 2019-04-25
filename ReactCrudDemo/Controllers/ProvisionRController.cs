using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactCrudDemo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReactCrudDemo.Controllers
{
    public class ProvisionRController : Controller
    {
        ProvisionRDataAccessLayer objProvisionR = new ProvisionRDataAccessLayer();

        #region Account

        /*
        [HttpGet]
        [Route("api/Account/Index")]
        public IEnumerable<Account> ListAccounts()
        {
            return objProvisionR.GetAllAccounts();
        }
        */

        [HttpGet]
        [Route("api/Account/Index")]
        public Dictionary<string, IEnumerable<Account>> ListAccounts()
        {
            return new Dictionary<string, IEnumerable<Account>>
            {
                {"data", objProvisionR.GetAllAccounts()}
            };
        }

        [HttpPost]
        [Route("api/Account/Create")]
        public int CreateAccount(Account account)
        {
            return objProvisionR.AddAccount(account);
        }

        [HttpGet]
        [Route("api/Account/Details/{id}")]
        public Account GetAccountDetails(int id)
        {
            return objProvisionR.GetAccountData(id);
        }

        [HttpPut]
        [Route("api/Account/Edit")]
        public int EditAccount(Account account)
        {
            return objProvisionR.UpdateAccount(account);
        }

        [HttpDelete]
        [Route("api/Account/Delete/{id}")]
        public int DeleteAccount(int id)
        {
            return objProvisionR.DeleteAccount(id);
        }

        #endregion

        #region ComputeNode

        /*
        [HttpGet]
        [Route("api/ComputeNode/Index")]
        public IEnumerable<ComputeNode> ListComputeNodes()
        {
            // return objProvisionR.GetAllComputeNodes();
            return new Dictionary<string, object> {}
        }
        */

        [HttpGet]
        [Route("api/ComputeNode/Index")]
        public Dictionary<string, IEnumerable<ComputeNode>> ListComputeNodes()
        {
            return new Dictionary<string, IEnumerable<ComputeNode>>
            {
                {"data", objProvisionR.GetAllComputeNodes()}
            };
        }

        [HttpPost]
        [Route("api/ComputeNode/Create")]
        public int CreateComputeNode(ComputeNode node)
        {
            return objProvisionR.AddComputeNode(node);
        }

        [HttpGet]
        [Route("api/ComputeNode/Details/{id}")]
        public ComputeNode GetComputeNodeDetails(int id)
        {
            return objProvisionR.GetComputeNodeData(id);
        }

        [HttpPut]
        [Route("api/ComputeNode/Edit")]
        public int EditComputeNode(ComputeNode node)
        {
            return objProvisionR.UpdateComputeNode(node);
        }

        [HttpDelete]
        [Route("api/ComputeNode/Delete/{id}")]
        public int DeleteComputeNode(int id)
        {
            return objProvisionR.DeleteComputeNode(id);
        }

        #endregion
        
        #region Flavor

        /*
        [HttpGet]
        [Route("api/Flavor/Index")]
        public IEnumerable<Flavor> ListFlavors()
        {
            return objProvisionR.GetAllFlavors();
        }
        */

        [HttpGet]
        [Route("api/Flavor/Index")]
        public Dictionary<string, IEnumerable<Flavor>> ListFlavors()
        {
            return new Dictionary<string, IEnumerable<Flavor>>
            {
                {"data", objProvisionR.GetAllFlavors()}
            };
        }

        [HttpPost]
        [Route("api/Flavor/Create")]
        public int CreateFlavor(Flavor flavor)
        {
            return objProvisionR.AddFlavor(flavor);
        }

        [HttpGet]
        [Route("api/Flavor/Details/{id}")]
        public Flavor GetFlavorDetails(int id)
        {
            return objProvisionR.GetFlavorData(id);
        }

        [HttpPut]
        [Route("api/Flavor/Edit")]
        public int EditFlavor(Flavor flavor)
        {
            return objProvisionR.UpdateFlavor(flavor);
        }

        [HttpDelete]
        [Route("api/Flavor/Delete/{id}")]
        public int DeleteFlavor(int id)
        {
            return objProvisionR.DeleteFlavor(id);
        }

        #endregion

        #region Image

        /*
        [HttpGet]
        [Route("api/Image/Index")]
        public IEnumerable<Image> ListImages()
        {
            return objProvisionR.GetAllImages();
        }
        */

        [HttpGet]
        [Route("api/Image/Index")]
        public Dictionary<string, IEnumerable<Image>> ListImages()
        {
            return new Dictionary<string, IEnumerable<Image>>
            {
                {"data", objProvisionR.GetAllImages()}
            };
        }

        [HttpPost]
        [Route("api/Image/Create")]
        public int CreateImage(Image image)
        {
            return objProvisionR.AddImage(image);
        }

        [HttpGet]
        [Route("api/Image/Details/{id}")]
        public Image GetImageDetails(int id)
        {
            return objProvisionR.GetImageData(id);
        }

        [HttpPut]
        [Route("api/Image/Edit")]
        public int EditImage(Image image)
        {
            return objProvisionR.UpdateImage(image);
        }

        [HttpDelete]
        [Route("api/Image/Delete/{id}")]
        public int DeleteImage(int id)
        {
            return objProvisionR.DeleteImage(id);
        }

        #endregion
        
        #region Instance

        /*
        [HttpGet]
        [Route("api/Instance/Index")]
        public IEnumerable<Instance> ListInstances()
        {
            return objProvisionR.GetAllInstances();
        }
        */

        [HttpGet]
        [Route("api/Instance/Index")]
        public Dictionary<string, IEnumerable<Instance>> ListInstances()
        {
            return new Dictionary<string, IEnumerable<Instance>>
            {
                {"data", objProvisionR.GetAllInstances()}
            };
        }

        [HttpPost]
        [Route("api/Instance/Create")]
        public int CreateInstance(Instance instance)
        {
            return objProvisionR.AddInstance(instance);
        }

        [HttpGet]
        [Route("api/Instance/Details/{id}")]
        public Instance GetInstanceDetails(int id)
        {
            return objProvisionR.GetInstanceData(id);
        }

        [HttpPut]
        [Route("api/Instance/Edit")]
        public int EditInstance(Instance instance)
        {
            return objProvisionR.UpdateInstance(instance);
        }

        [HttpDelete]
        [Route("api/Instance/Delete/{id}")]
        public int DeleteInstance(int id)
        {
            return objProvisionR.DeleteInstance(id);
        }

        #endregion
        
        #region Job

        /*
        [HttpGet]
        [Route("api/Job/Index")]
        public IEnumerable<Job> ListJobs()
        {
            return objProvisionR.GetAllJobs();
        }
        */

        [HttpGet]
        [Route("api/Job/Index")]
        public Dictionary<string, IEnumerable<Job>> ListJobs()
        {
            return new Dictionary<string, IEnumerable<Job>>
            {
                {"data", objProvisionR.GetAllJobs()}
            };
        }

        [HttpPost]
        [Route("api/Job/Create")]
        public int CreateJob(Job job)
        {
            return objProvisionR.AddJob(job);
        }

        [HttpGet]
        [Route("api/Job/Details/{id}")]
        public Job GetJobDetails(int id)
        {
            return objProvisionR.GetJobData(id);
        }

        [HttpPut]
        [Route("api/Job/Edit")]
        public int EditJob(Job job)
        {
            return objProvisionR.UpdateJob(job);
        }

        [HttpDelete]
        [Route("api/Job/Delete/{id}")]
        public int DeleteJob(int id)
        {
            return objProvisionR.DeleteJob(id);
        }

        #endregion
        
        #region Kiosk

        /*
        [HttpGet]
        [Route("api/Kiosk/Index")]
        public IEnumerable<Kiosk> ListKiosks()
        {
            return objProvisionR.GetAllKiosks();
        }
        */

        [HttpGet]
        [Route("api/Kiosk/Index")]
        public Dictionary<string, IEnumerable<Kiosk>> ListKiosks()
        {
            return new Dictionary<string, IEnumerable<Kiosk>>
            {
                {"data", objProvisionR.GetAllKiosks()}
            };
        }

        [HttpPost]
        [Route("api/Kiosk/Create")]
        public int CreateKiosk(Kiosk kiosk)
        {
            return objProvisionR.AddKiosk(kiosk);
        }

        [HttpGet]
        [Route("api/Kiosk/Details/{id}")]
        public Kiosk GetKioskDetails(int id)
        {
            return objProvisionR.GetKioskData(id);
        }

        [HttpPut]
        [Route("api/Kiosk/Edit")]
        public int EditKiosk(Kiosk kiosk)
        {
            return objProvisionR.UpdateKiosk(kiosk);
        }

        [HttpDelete]
        [Route("api/Kiosk/Delete/{id}")]
        public int DeleteKiosk(int id)
        {
            return objProvisionR.DeleteKiosk(id);
        }

        #endregion

        #region Resource

        /*
        [HttpGet]
        [Route("api/Resource/Index")]
        public IEnumerable<Resource> ListResources()
        {
            return objProvisionR.GetAllResources();
        }
        */

        [HttpGet]
        [Route("api/Resource/Index")]
        public Dictionary<string, IEnumerable<Resource>> ListResources()
        {
            return new Dictionary<string, IEnumerable<Resource>>
            {
                {"data", objProvisionR.GetAllResources()}
            };
        }

        [HttpPost]
        [Route("api/Resource/Create")]
        public int CreateResource(Resource resource)
        {
            return objProvisionR.AddResource(resource);
        }

        [HttpGet]
        [Route("api/Resource/Details/{id}")]
        public Resource GetResourceDetails(int id)
        {
            return objProvisionR.GetResourceData(id);
        }

        [HttpPut]
        [Route("api/Resource/Edit")]
        public int EditResource(Resource resource)
        {
            return objProvisionR.UpdateResource(resource);
        }

        [HttpDelete]
        [Route("api/Resource/Delete/{id}")]
        public int DeleteResource(int id)
        {
            return objProvisionR.DeleteResource(id);
        }

        #endregion
        
        #region VLan

        /*
        [HttpGet]
        [Route("api/VLan/Index")]
        public IEnumerable<VLan> ListVLans()
        {
            return objProvisionR.GetAllVLans();
        }
        */

        [HttpGet]
        [Route("api/VLan/Index")]
        public Dictionary<string, IEnumerable<VLan>> ListVLans()
        {
            return new Dictionary<string, IEnumerable<VLan>>
            {
                {"data", objProvisionR.GetAllVLans()}
            };
        }

        [HttpPost]
        [Route("api/VLan/Create")]
        public int CreateVLan(VLan vlan)
        {
            return objProvisionR.AddVLan(vlan);
        }

        [HttpGet]
        [Route("api/VLan/Details/{id}")]
        public VLan GetVLanDetails(int id)
        {
            return objProvisionR.GetVLanData(id);
        }

        [HttpPut]
        [Route("api/VLan/Edit")]
        public int EditVLan(VLan vlan)
        {
            return objProvisionR.UpdateVLan(vlan);
        }

        [HttpDelete]
        [Route("api/VLan/Delete/{id}")]
        public int DeleteVLan(int id)
        {
            return objProvisionR.DeleteVLan(id);
        }

        #endregion
//        [HttpGet]
//        [Route("api/Employee/GetCityList")]
//        public IEnumerable<TblCities> Details()
//        {
//            return objProvisionR.GetCities();
//        }
    }
}
