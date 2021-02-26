﻿using System.Threading.Tasks;
using WebApiClientCore.Attributes;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// 模板消息接口
    /// </summary>
    [HttpHost("https://api.weixin.qq.com/cgi-bin/message/template/")]
    public interface ITemplateApi : IWxApiWithAccessTokenFilter
    {
        /// <summary>
        /// 发送模板消息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("send")]
        Task<SendTemplateMessageApiResult> SendAsync([JsonNetContent(CharSet = "utf-8")] SendTemplateMessageInput input);

        /// <summary>
        /// 设置所属行业
        /// </summary>
        /// <returns></returns>
        [HttpPost("api_set_industry")]
        Task<ApiResultBase> SetIndustryAsync([JsonNetContent(CharSet = "utf-8")] SetIndustryInput input);

        /// <summary>
        ///获取设置的行业信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_industry")]
        Task<GetIndustryResult> GetIndustryAsync();


        /// <summary>
        /// 根据模板编号获得模板ID
        /// </summary>
        /// <returns></returns>
        [HttpPost("api_add_template")]
        Task<GetTemplateIdApiResult> GetTemplateIdAsync(GetTemplateIdInput input);
    }
}
