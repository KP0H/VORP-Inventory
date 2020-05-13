﻿using System.Collections.Generic;

namespace vorpinventory_sv
{
    public class WeaponClass
    {
        private string name;
        private int id;
        private string propietary;
        private Dictionary<string, int> ammo;
        private List<string> components;
        public WeaponClass(int id,string propietary,string name, Dictionary<string,int>ammo,List<string>components)
        {
            this.id = id;
            this.name = name;
            this.ammo = ammo;
            this.components = components;
            this.propietary = propietary;
        }

        public string getPropietary()
        {
            return this.propietary;
        }

        public void setPropietary(string propietary)
        {
            this.propietary = propietary;
        }
        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getName()
        {
            return this.name;
        }

        public Dictionary<string, int> getAllAmmo()
        {
            return this.ammo;
        }

        public List<string> getAllComponents()
        {
            return this.components;
        }

        public void setComponent(string component)
        {
            this.components.Add(component);
        }

        public void quitComponent(string component)
        {
            if (this.components.Contains(component))
            {
                this.components.Remove(component);
            }
        }

        public int getAmmo(string type)
        {
            if (this.ammo.ContainsKey(type))
            {
                return this.ammo[type];
            }
            else
            {
                return 0;
            }
            
        }

        public void addAmmo(int ammo,string type)
        {
            if (this.ammo.ContainsKey(type))
            {
                this.ammo[type] += ammo;
            }
            else
            {
                this.ammo.Add(type,ammo);
            }
        }

        public void subAmmo(int ammo,string type)
        {
            if (this.ammo.ContainsKey(type))
            {
                this.ammo[type] -= ammo;
                if (this.ammo[type] == 0)
                {
                    this.ammo.Remove(type);
                }
            }
        }
        
    }
}