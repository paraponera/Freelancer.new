jQuery(document).ready(function(a){a(".connections-list").cn_preloader({delay:100,imgSelector:".cn-image-loading img.photo, .cn-image-loading img.logo, .cn-image-loading img.map, .cn-image-loading img.screenshot",beforeShow:function(){a(this).closest(".cn-image-loading img").css("visibility","hidden");
},afterShow:function(){}});});