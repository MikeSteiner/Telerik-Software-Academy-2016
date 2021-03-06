/**
 * Created by admin on 6.8.2016 г..
 */
$.fn.startingSideBar = function () {

    var sideProperties = {
        name: "side object",
        imgsCount: 5,
        selectedImageIndex: 1,
        selectedImgObj: null
    };

    function sideBarMain() {
        //- Variables and objects declaration start

        var sideImgsUrl = [
            "image",
            "image",
            "image",
            "image",
            "image"
        ]

        var stylesUl = {
            "list-style-type" : "none",
            "margin" : "0",
            "padding" : "0"
        };

        var stylesLi = {
            "margin" : "0",
            "padding" : "2"
        };

        var stylesImg = {
            "border" : "1px solid gray",
            "border-radius" : "5px",
            "cursor" : "pointer"
        };

        var $sideWrapper = $(".sidebar-images"), // Main side div
            $sideUl,
            $sideLi,
            $sideImg,
            $selectedImg;


        //-- Variables and objects declaration end

        //- Logic start **************************************
        $sideUl = createDomElement("ul", "side-ul", "", stylesUl);

        for(var i = 0, len = sideProperties.imgsCount; i < len; i += 1){
            var onePlusIx = Number(1 + i);

            $sideImg = createDomElement("img", "side-img-" + onePlusIx, "", stylesImg);
            setImgAttributes($sideImg, 190, 140, "Images/colored/" + sideImgsUrl[i] + onePlusIx + ".png");
            $sideLi = createDomElement("li", "", "side-imgs-list", stylesLi);

            $sideImg.click(onClickSelectImg);

            $sideLi.append($sideImg);
            $sideUl.append($sideLi);
        }




        $sideWrapper.append($sideUl);



        //-- Logic end **************************************


        // selectedImg = document.querySelector("img")[0];
        // selectedImg = document.querySelector("img")[sideProperties.selectedImgObj];
        selectedImg = sideProperties.selectedImgObj;

        return selectedImg;
    }


    //- Sub Functions declaration start

    function setImgAttributes(imgToSetAttributes, width, height, src) {
        // $(imgToSetAttributes).width = width;
        // $(imgToSetAttributes).height = height;
        $(imgToSetAttributes).attr("src", src).width(width).height(height);
    }

    function createDomElement(name, cssId, cssClass, cssStyles) {
        cssId = "" + cssId;
        cssClass = "" + cssClass;

        var newElement = document.createElement(name);

        // Add css id the the element
        if(!checkIfStringEmptyNullNothing(cssId)){
            $(newElement).attr('id', cssId);
        }

        // Add css class to the element
        if(!checkIfStringEmptyNullNothing(cssClass)){
            $(newElement).addClass(cssClass);
        }

        // Add css styles to the element
        if(!checkIfStringEmptyNullNothing(cssStyles)){
            $(newElement).css(cssStyles);
        }

        return $(newElement);
    }

    function getSelectedImgIx() {

        return sideProperties.selectedImageIndex;
    }

    function getSelectedImg() {

        return sideProperties.selectedImgObj;
    }

    function checkIfStringEmptyNullNothing(stringForCheck) {

        //return (val === undefined || val == null || val.length <= 0)
        if(stringForCheck === ""){
            return true;
        }
        if(stringForCheck == null){
            return true;
        }
        if(stringForCheck === undefined){
            return true;
        }
        if(stringForCheck.length < 2){
            return true;
        }

        return false;
    }

    function onClickSelectImg(ev) {
        //var $imgSelected = ev.target;
        var idSplitted = event.target.id.split('-');
        var imgIx = Number(idSplitted[idSplitted.length - 1]);

        sideProperties.selectedImageIndex = imgIx;
        sideProperties.selectedImgObj = ev.target;

        var mImgSrc = updateMainImgSrc();

        console.log("src: " + mImgSrc);
        console.log("index: " + sideProperties.selectedImageIndex);
        console.log("image object: " + sideProperties.selectedImgObj);
    }

    function  updateMainImgSrc() {

        var mainImg = document.querySelector('.front')[0],
            mainImgSrc = '',
            mainImgIx = sideProperties.selectedImageIndex;

        mainImgSrc =  "Images/raw/" + sideImgsUrl[mainImgIx] + ".png";
        $(mainImg).attr('src', mainImgSrc);

        return mainImgSrc;
    }
    //-- Functions declaration end


    //- Function calls
    sideBarMain();
};



