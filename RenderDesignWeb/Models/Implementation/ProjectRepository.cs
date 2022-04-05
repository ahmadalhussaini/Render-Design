﻿using Microsoft.EntityFrameworkCore;
using RenderDesignWeb.Context;
using RenderDesignWeb.Models.Interface;
using System.Collections.Generic;
using System.Linq;

namespace RenderDesignWeb.Models.Implementation
{
    public class ProjectRepository : IProjectRepository
    {
        readonly RenderDesignContext db;
        public ProjectRepository(RenderDesignContext db)
        {
            db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            this.db = db;
        }

        public Project Add(Project entity)
        {
            var project = db.Projects.Add(entity);
            db.SaveChanges();
            return project.Entity;
        }

        public void Delete(Project entity)
        {
            db.Projects.Remove(entity);
            db.SaveChanges();
        }

        public Project GetProject(int Id)
        {
            var project = db.Projects.SingleOrDefault(b => b.Id == Id);
            return project;
        }

        public List<Project> GetProjects()
        {
            var project = db.Projects.ToList();
            return project;
        }

        public List<Project> GetProjects(string type)
        {
            var project = db.Projects.Where(x => x.Type == type).ToList();
            return project;
        }

        public List<Project> GetProjects(Designer designer)
        {
            var project = db.Projects.Where(x => x.Designer == designer).ToList();
            return project;
        }

        public void Update(Project entity)
        {
            db.Projects.Update(entity);
            db.SaveChanges();
        }
    }
}
