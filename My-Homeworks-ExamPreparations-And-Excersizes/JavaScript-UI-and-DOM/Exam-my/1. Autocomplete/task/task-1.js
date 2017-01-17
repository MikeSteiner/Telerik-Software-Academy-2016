/* globals document, window, console */

function solve() {
    return function(selector, initialSuggestions) {

        var mainDivElement = window.document.querySelector(selector);
        var inputElement = mainDivElement.firstElementChild;
        var addElement = mainDivElement.getElementsByTagName('a')[0];
        var ulElement = mainDivElement.getElementsByTagName('ul')[0];

        // console.log(mainDivElement);
        // console.log(inputElement);
        // console.log(aElement);
        // console.log(ulElement);

        console.log(selector);
        console.log(initialSuggestions);

        //*****************************************
        // functions declaration Start

        // TODO function description here
        function addSuggestionToArray(ev) {

            var newSuggestion = inputElement.value;

            if(newSuggestion !== '' || newSuggestion !== undefined) {

                var isExisting = suggestionIsExisting(newSuggestion);

                var isUndefinedText = false;
                if(newSuggestion === 'undefined' || newSuggestion === ''){
                    isUndefinedText = true;
                }


                if(!isExisting && !isUndefinedText){
                    initialSuggestions.push(newSuggestion);

                    traverseSuggestionsArray();

                    inputElement.value = '';
                }

            } else{
                //do nothing
            }

            hideAllLiElements();
            inputElement.value = '';
            //console.toLocaleString(newSuggestion);
        }

        function suggestionIsExisting(newSuggestionText) {

            var items = ulElement.getElementsByTagName('li');

            for (var i = 0; i < items.length; ++i) {
                var liEl = items[i];
                var currentSuggestionText = liEl.getElementsByTagName("a")[0].innerHTML;

                var areEqual = currentSuggestionText.toLowerCase() === newSuggestionText.toLowerCase();

                if(areEqual){

                    return true;
                }
            }

            return false;
        }

        // TODO function description here
        function clearUlList() {
            ulElement.innerHTML = '';
        }

        // TODO function description here
        function  traverseSuggestionsArray() {
            if(initialSuggestions !== null && initialSuggestions !== undefined){

                clearUlList();

                for(suggestion of initialSuggestions){

                    var isExisting = suggestionIsExisting(suggestion);
                    var isUndefinedText = (suggestion === 'undefined');

                    if(!isExisting || isUndefinedText){
                        var liElement = createLiElementAndFillWithText(suggestion);
                        if(liElement !== null){
                            ulElement.appendChild(liElement);
                        }
                    }
                }

                return true;
            } else {

                return false;
            }
        }

        // TODO function description here
        function createLiElementAndFillWithText (inText) {

            if(inText !== '' && inText !== undefined){

                var liEl = window.document.createElement('li');
                liEl.id = inText.toLowerCase() + '-li';
                liEl.className = 'suggestion';

                liEl.innerHTML = '<a href="#" class="suggestion-link" id="' + inText.toLowerCase() + '">' + inText + '</a>';

                // add event on clisk to the a element
                var aElem = liEl.getElementsByTagName('a')[0];
                aElem.addEventListener("click", insertSelectedSuggestionInTheInputElement, false);

                return liEl;
            }else{

                return false;
            }
        }

        // TODO function description here
        function onWritingInInput(ev) {
            var inputValue = ev.target.value;

            console.log(inputValue);
        }

        function hideAllLiElements() {
            var items = ulElement.getElementsByTagName('li');
            for (var i = 0; i < items.length; ++i) {
                items[i].style.display = 'none';
            }
        }

        function showElementsContainingSuggestion(ev) {

            var items = ulElement.getElementsByTagName('li');

            for (var i = 0; i < items.length; ++i) {
                var liEl = items[i];
                var currentSuggestionText = liEl.getElementsByTagName("a")[0].innerHTML.toLowerCase();
                var inputText  = inputElement.value.toLowerCase();

                if(inputText === ''){
                    hideAllLiElements();
                } else {
                    var isSuggestion = currentSuggestionText.includes(inputText);
                    if(isSuggestion){
                        liEl.style.display = 'block';
                    }
                }

            }
        }

        function  hideShowLiElementsOnTyping() {
            hideAllLiElements();
            showElementsContainingSuggestion();
        }

        function insertSelectedSuggestionInTheInputElement(ev) {
            var currentAElementText = ev.target.innerText;
            inputElement.value = currentAElementText;

            hideAllLiElements();

        }
        // functions declaration End

        //*****************************************
        // functions call Start

        traverseSuggestionsArray();
        hideAllLiElements();

        addElement.addEventListener("click", addSuggestionToArray, false);
        //inputElement.addEventListener("input", onWritingInInput, false);
        inputElement.addEventListener("input", hideShowLiElementsOnTyping, false);

        // functions call End

        //*****************************************
        // final append elements to DOM
    };
}

// submit the above

module.exports = solve;