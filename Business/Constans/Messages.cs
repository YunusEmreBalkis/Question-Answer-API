using Core.Entities.Concrete;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string QuestionAdded = "Soru eklendi";
        public static string QuestionContentInvalid = "Soru içeriği geçirsiz";
        public static string MaintenanceTime ="Sistem bakımda";
        public static string QuestionListed="Sorular listelendi";
        public static string AnswerListed = "Cevaplar listelendi";
        public static string UserAdded = "Kullanıcı başarılı bir şekilde eklendi";
        public static string UsersListed = "Kullanıcıalar başarılı bir şekilde listelendi";
        public static string UserNameAlreadyExists = "Bu isimle başka bir kullanıcı var lütfen yeni bir kullanıcı adı belirleyiniz";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError= "Parola hatası";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string QuestionUpdated = "Soru başarılı bir şekilde güncellendi";
        public static string AnswerUpdated = "Cevap başarılı bir şekilde güncellendi";
        public static string UserUpdated = "Kullanıcı başarılı bir şekilde güncellendi";
        public static string UserDeleted = "Kullanıcı başarılı bir şekilde silindi";
        public static string QuestionDeleted = "Soru başarılı bir şekilde silindi";
        public static string AnswerDeleted = "Cevap başarılı bir şekilde silindi";
        public static string QuestionNotFound = "Cevaplamak istediğiniz soru bulunamadı.";
        public static string AnswerAdded = "Cevap başarılı bir şekilde eklendi";
    }
}
