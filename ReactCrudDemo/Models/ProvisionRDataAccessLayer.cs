using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactCrudDemo.Models
{
    public class ProvisionRDataAccessLayer
    {
        ProvisionRContext db = new ProvisionRContext();
        
        #region Accounts
        
        public IEnumerable<Account> GetAllAccounts()
        {
            try
            {
                return db.TAccounts.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new account record   
        public int AddAccount(Account account)
        {
            try
            {
                db.TAccounts.Add(account);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar account  
        public int UpdateAccount(Account account)
        {
            try
            {
                db.Entry(account).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular account  
        public Account GetAccountData(int id)
        {
            try
            {
                var account = db.TAccounts.Find(id);
                return account;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular account  
        public int DeleteAccount(int id)
        {
            try
            {
                var account = db.TAccounts.Find(id);
                db.TAccounts.Remove(account);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region ComputeNodes
        
        public IEnumerable<ComputeNode> GetAllComputeNodes()
        {
            try
            {
                return db.TComputeNodes.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new account computenode   
        public int AddComputeNode(ComputeNode node)
        {
            try
            {
                db.TComputeNodes.Add(node);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar account  
        public int UpdateComputeNode(ComputeNode node)
        {
            try
            {
                db.Entry(node).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular account  
        public ComputeNode GetComputeNodeData(int id)
        {
            try
            {
                var node = db.TComputeNodes.Find(id);
                return node;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular account  
        public int DeleteComputeNode(int id)
        {
            try
            {
                var node = db.TComputeNodes.Find(id);
                db.TComputeNodes.Remove(node);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region Flavors
        
        public IEnumerable<Flavor> GetAllFlavors()
        {
            try
            {
                return db.MFlavors.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new flavor record
        public int AddFlavor(Flavor flavor)
        {
            try
            {
                db.MFlavors.Add(flavor);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar flavor
        public int UpdateFlavor(Flavor flavor)
        {
            try
            {
                db.Entry(flavor).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular flavor
        public Flavor GetFlavorData(int id)
        {
            try
            {
                var flavor = db.MFlavors.Find(id);
                return flavor;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular flavor
        public int DeleteFlavor(int id)
        {
            try
            {
                var flavor = db.MFlavors.Find(id);
                db.MFlavors.Remove(flavor);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region Images
        
        public IEnumerable<Image> GetAllImages()
        {
            try
            {
                return db.MImages.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new image record
        public int AddImage(Image image)
        {
            try
            {
                db.MImages.Add(image);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar image
        public int UpdateImage(Image image)
        {
            try
            {
                db.Entry(image).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular image
        public Image GetImageData(int id)
        {
            try
            {
                var image = db.MImages.Find(id);
                return image;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular image
        public int DeleteImage(int id)
        {
            try
            {
                var image = db.MImages.Find(id);
                db.MImages.Remove(image);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region Instances
        
        public IEnumerable<Instance> GetAllInstances()
        {
            try
            {
                return db.TInstances.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new instance record
        public int AddInstance(Instance instance)
        {
            try
            {
                db.TInstances.Add(instance);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar instance
        public int UpdateInstance(Instance instance)
        {
            try
            {
                db.Entry(instance).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular instance
        public Instance GetInstanceData(int id)
        {
            try
            {
                var instance = db.TInstances.Find(id);
                return instance;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular instance
        public int DeleteInstance(int id)
        {
            try
            {
                var instance = db.TInstances.Find(id);
                db.TInstances.Remove(instance);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region Jobs
        
        public IEnumerable<Job> GetAllJobs()
        {
            try
            {
                return db.TJobs.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new job record   
        public int AddJob(Job job)
        {
            try
            {
                db.TJobs.Add(job);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar job  
        public int UpdateJob(Job job)
        {
            try
            {
                db.Entry(job).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular job  
        public Job GetJobData(int id)
        {
            try
            {
                var job = db.TJobs.Find(id);
                return job;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular job  
        public int DeleteJob(int id)
        {
            try
            {
                var job = db.TJobs.Find(id);
                db.TJobs.Remove(job);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        #endregion
        
        #region Kiosks
        
        public IEnumerable<Kiosk> GetAllKiosks()
        {
            try
            {
                return db.TKiosk.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new kiosk record
        public int AddKiosk(Kiosk kiosk)
        {
            try
            {
                db.TKiosk.Add(kiosk);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar kiosk
        public int UpdateKiosk(Kiosk kiosk)
        {
            try
            {
                db.Entry(kiosk).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular kiosk
        public Kiosk GetKioskData(int id)
        {
            try
            {
                var kiosk = db.TKiosk.Find(id);
                return kiosk;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular kiosk
        public int DeleteKiosk(int id)
        {
            try
            {
                var kiosk = db.TKiosk.Find(id);
                db.TKiosk.Remove(kiosk);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region Resources
        
        public IEnumerable<Resource> GetAllResources()
        {
            try
            {
                return db.TResource.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new resource record
        public int AddResource(Resource resource)
        {
            try
            {
                db.TResource.Add(resource);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar resource
        public int UpdateResource(Resource resource)
        {
            try
            {
                db.Entry(resource).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular resource
        public Resource GetResourceData(int id)
        {
            try
            {
                var resource = db.TResource.Find(id);
                return resource;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular resource
        public int DeleteResource(int id)
        {
            try
            {
                var resource = db.TResource.Find(id);
                db.TResource.Remove(resource);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region VLans
        
        public IEnumerable<VLan> GetAllVLans()
        {
            try
            {
                return db.TVLan.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new vlan record
        public int AddVLan(VLan vlan)
        {
            try
            {
                db.TVLan.Add(vlan);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar vlan
        public int UpdateVLan(VLan vlan)
        {
            try
            {
                db.Entry(vlan).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular vlan
        public VLan GetVLanData(int id)
        {
            try
            {
                var vlan = db.TVLan.Find(id);
                return vlan;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular vlan
        public int DeleteVLan(int id)
        {
            try
            {
                var vlan = db.TVLan.Find(id);
                db.TVLan.Remove(vlan);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        #endregion

        //To Get the list of Cities  
        /*
        public List<TblCities> GetCities()
        {
            List<TblCities> lstCity = new List<TblCities>();
            lstCity = (from CityList in db.TblCities select CityList).ToList();

            return lstCity;
        }
        */

    }
}
