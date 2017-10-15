using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _01_MVCBasic.Models
{
    public class Person
    {
        //为模型添加校验特性
        //添加DataAnnotations
        [Required(ErrorMessage = "abc")]
        public string Name { get; set; }

        //支持添加多了特性
        [Required(ErrorMessage = "不需要求")]
        [Range(10,100,ErrorMessage ="值要在10-100之间 ")]
        public int Age { get; set; }
        private string _nickName;

        public Person()
        {

        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            _nickName = Name;
        }

        private int ModifyAge(int factor)
        {
            return Age * factor;
        }
    }
}