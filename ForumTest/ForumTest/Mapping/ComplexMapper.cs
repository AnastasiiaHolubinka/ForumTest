using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ForumTestBLL.DTO;
using ForumTest.Models;

namespace ForumTest.Mapping
{
    public static class ComplexMapper
    {
        public static ForumDTO Map(ForumModel forumModel)
        {
            ForumDTO result = MapperBag.ForumMapper.Map(forumModel);
            result.TopicDtos = MapperBag.TopicMapper.Map(forumModel.Topics).ToList();
            return result;
        }

        public static TopicDTO Map(TopicModel topicModel)
        {
            TopicDTO result = MapperBag.TopicMapper.Map(topicModel);
            result.PostDtos = MapperBag.PostMapper.Map(topicModel.Posts).ToList();
            return result;
        }
    }
}