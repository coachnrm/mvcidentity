using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yt_Dot6Identity.Models;
using Yt_Dot6Identity.Models.Domain;


namespace Yt_Dot6Identity.Controllers
{

    public class NurseRequestController : Controller
    {
        private readonly DatabaseContext context;
        public NurseRequestController(DatabaseContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var nurserequest = context.NurseRequest.OrderByDescending(p => p.JobId).ToList();
            return View(nurserequest);
        }
         public IActionResult Create()
         {
             return View();
         }

        [HttpPost]
        public IActionResult Create(NurseRequestDto nurseRequestDto)
        {
            if (ModelState.IsValid)
            {
                return View(nurseRequestDto);
            }
            
            NurseRequest nurseRequest = new NurseRequest()
            {
                QN = nurseRequestDto.QN,
                QNName = nurseRequestDto.QNName,
                StartPoint = nurseRequestDto.StartPoint,
                EndPoint = nurseRequestDto.EndPoint,
                MaterialType = nurseRequestDto.MaterialType,
                UrentType = nurseRequestDto.UrentType,
                PatientType = nurseRequestDto.PatientType,
                Remark = nurseRequestDto.Remark,
                Department = "null",
                JobStatusName = "null",
                PoterFname = "null",
                QNAge = "null",
                QNSex = "null",
            };
            context.NurseRequest.Add(nurseRequest);
            context.SaveChanges();
            return RedirectToAction("Index", "NurseRequest");
        }

        public IActionResult Edit(int id)
        {
            var nurseRequest = context.NurseRequest.Find(id);
            if(nurseRequest == null)
            {
                return RedirectToAction("Index", "NurseRequest");
            }
            var nurseRequestDto = new NurseRequestDto()
            {
                QN = nurseRequest.QN,
                QNName = nurseRequest.QNName,
                StartPoint = nurseRequest.StartPoint,
                EndPoint = nurseRequest.EndPoint,
                MaterialType = nurseRequest.MaterialType,
                UrentType = nurseRequest.UrentType,
                PatientType = nurseRequest.PatientType,
                Remark = nurseRequest.Remark,
                Department = "null",
                JobStatusName = "null",
                PoterFname = "null",
                QNAge = "null",
                QNSex = "null",
            };

             ViewData["NurseRequestId"] = nurseRequest.JobId;

            return View(nurseRequestDto);
        }
        [HttpPost]
         public IActionResult Edit(int id, NurseRequestDto nurseRequestDto)
         {
            var nurseRequest = context.NurseRequest.Find(id);
            if(nurseRequest == null)
            {
                return RedirectToAction("Index", "NurseRequest");
            }
            if (ModelState.IsValid)
            {
                ViewData["NurseRequestId"] = nurseRequest.JobId;
                return View(nurseRequestDto);
            }

            nurseRequest.QN = nurseRequestDto.QN;
            nurseRequest.QNName = nurseRequestDto.QNName;
            nurseRequest.StartPoint = nurseRequestDto.StartPoint;
            nurseRequest.EndPoint = nurseRequestDto.EndPoint;
            nurseRequest.MaterialType = nurseRequestDto.MaterialType;
            nurseRequest.UrentType = nurseRequestDto.UrentType;
            nurseRequest.PatientType = nurseRequestDto.PatientType;
            nurseRequest.Remark = nurseRequestDto.Remark;

            context.SaveChanges();

            return RedirectToAction("Index", "NurseRequest");
         }
         public IActionResult Delete(int id)
        {
            var nurseRequest = context.NurseRequest.Find(id);
            if(nurseRequest == null)
            {
                return RedirectToAction("Index", "NurseRequest");
            }
            context.NurseRequest.Remove(nurseRequest);
            context.SaveChanges(true);

            return RedirectToAction("Index", "NurseRequest");
        }
    }

}