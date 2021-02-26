using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ForumTestBLL.DTO;
using ForumTest.Models;

namespace ForumTest.Mapping
{
    public static class MapperBag
    {
        public static MapperWrapper<ForumDTO, ForumModel> ForumMapper
        {
            get { return new MapperWrapper<ForumDTO, ForumModel>(); }
        }

        public static MapperWrapper<TopicDTO, TopicModel> TopicMapper
        {
            get { return new MapperWrapper<TopicDTO, TopicModel>(); }
        }

        public static MapperWrapper<UserDTO, UserModel> UserMapper
        {
            get { return new MapperWrapper<UserDTO, UserModel>(); }
        }

        public static MapperWrapper<UserProfileDTO, UserProfileModel> UserProfileMapper
        {
            get { return new MapperWrapper<UserProfileDTO, UserProfileModel>(); }
        }

        public static MapperWrapper<PostDTO, PostModel> PostMapper
        {
            get { return new MapperWrapper<PostDTO, PostModel>(); }
        }

    }
}