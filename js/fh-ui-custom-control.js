function custom_Control_Event() {

    const popoverTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="popover"]'));
    const popoverList = popoverTriggerList.map(function (popoverTriggerEl) {
        // added { html: true, sanitize: false } option to render button in content area of popover
        return new bootstrap.Popover(popoverTriggerEl, { html: true, sanitize: false });
    });



    function ConvertNumberToWords(doubleNumber, mainAmountType, decimalAmountType) {
        var beforeFloatingPoint = parseInt(doubleNumber.toString().split('.')[0]);
        // var beforeFloatingPointWord = NumberToWords(beforeFloatingPoint) + " " + (beforeFloatingPoint > 1 ? mainAmountType : mainAmountType.slice(0, -1));
        var beforeFloatingPointWord = NumberToWords(beforeFloatingPoint) + " " + mainAmountType;
        var afterFloatingPoint = parseInt(doubleNumber.toString().includes('.') ? doubleNumber.toString().split('.')[1] : "0");
        var afterFloatingPointWord = SmallNumberToWord(afterFloatingPoint, "") + " " + decimalAmountType + " only.";
        if (afterFloatingPoint > 0) {
            return beforeFloatingPointWord + " and " + afterFloatingPointWord;
        }
        else {
            return beforeFloatingPointWord + " only";
        }
    }
    function NumberToWords(number) {
        if (number == 0)
            return "zero";
        if (number < 0)
            return "minus " + NumberToWords(Math.abs(number));
        var words = "";
        if (number > 1000000000 && number / 1000000000 > 0) {
            words += NumberToWords(Math.floor(number / 1000000000)) + " billion ";
            number %= 1000000000;
        }
        if (number > 1000000 && number / 1000000 > 0) {
            words += NumberToWords(Math.floor(number / 1000000)) + " million ";
            number %= 1000000;
        }
        if (number > 1000 && number / 1000 > 0) {
            words += NumberToWords(Math.floor(number / 1000)) + " thousand ";
            number %= 1000;
        }
        if (number > 100 && number / 100 > 0) {
            words += NumberToWords(Math.floor(number / 100)) + " hundred ";
            number %= 100;
        }
        words = SmallNumberToWord(number, words);
        return words;
    }

    function SmallNumberToWord(number, words) {
        if (number <= 0) return words;
        if (words != "")
            words += "";
        var unitsMap = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];
        var tensMap = ["zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];
        if (number < 20)
            words += unitsMap[number];
        else {
            words += tensMap[Math.floor(number / 10)];
            if ((number % 10) > 0)
                words += " " + unitsMap[number % 10];
        }
        return words;
    }


    function formatDate(e) {
       
        value = e.val();
        // Remove non-digit characters
        value = value.replace(/\D/g, '');

        // Handle day part
        if (value.length > 2) {
            value = value.slice(0, 2) + '/' + value.slice(2);
        }

        // Handle month part
        if (value.length > 5) {
            value = value.slice(0, 5) + '/' + value.slice(5);
        }

        // Format the day part
        if (value.length <= 2) {
            if (value.length === 1 && Number(value) >= 1 && Number(value) <= 3) {
                value = value; // Allow single digit days 1-3
            } else if (value.length === 1 && Number(value) > 3) {
                value = '0' + value; // Single digit day, add leading zero
            } else if (value.length === 2) {
                if (Number(value) > 31) {
                    value = ''; // Max valid day
                    alert("Invalid day");
                }
            }
        }

        // Format the month part
        if (value.length > 2 && value.length <= 5) {
            let dayPart = value.slice(0, 2);
            let monthPart = value.slice(3, 5);

            if (monthPart.length === 1) {
                if (Number(monthPart) > 1) {
                    monthPart = '0' + monthPart; // Single digit month, add leading zero
                }
            } else if (monthPart.length === 2) {
                if (Number(monthPart) > 12) {
                    monthPart = ''; // Max valid month
                    alert("Invalid Month");
                }
            }
            value = dayPart + '/' + monthPart;
        }

        // Ensure no more than 10 characters
        if (value.length > 10) {
            value = value.slice(0, 10);
        }

        return value;
    }

    // Function to validate the date
    function validateDate(e) {

        var value = e.val();

        const parts = value.split('/');
        if (parts.length === 3) {
            const day = parseInt(parts[0], 10);
            const month = parseInt(parts[1], 10);
            const year = parseInt(parts[2], 10);

            if (year < 1000 || year > 9999 || parts[2][0] === '0') {
                alert("Invalid year");
                return parts[0] + '/' + parts[1] + '/';
            }

            const daysInMonth = new Date(year, month, 0).getDate();
            if (day > daysInMonth) {
                alert("Invalid day for the given month");
                return parts[0] + '/' + parts[1] + '/';
            }

            const inputDate = new Date(year, month - 1, day);

            var maxDate = e.attr("MaxDate");
            var minDate = e.attr("minDate");

            if (maxDate && maxDate !== null) {

                try {
                    var dateParts = maxDate.split("/");

                    // month is 0-based, that's why we need dataParts[1] - 1
                    var maxDateValue = new Date(+dateParts[2], dateParts[1] - 1, +dateParts[0]); 

                    if (inputDate > maxDateValue) {
                        fireToastEvent('bg-warning','Date is greater than the maximum allowed date');
                       // alert("Date is greater than the maximum allowed date: " + maxDate);
                        return parts[0] + '/' + parts[1] + '/';
                    }

                }
                catch (err) {}
               
            }

            if (minDate && minDate !== null) {

                try {
                    var dateParts = minDate.split("/");

                    // month is 0-based, that's why we need dataParts[1] - 1
                    var minDateValue = new Date(+dateParts[2], dateParts[1] - 1, +dateParts[0]);

                    if (inputDate < minDateValue) {
                        alert("Date is less than the minimum allowed date: " + minDate);
                        e.focus();
                        return parts[0] + '/' + parts[1] + '/';
                    }

                }
                catch (err) { }

            }

        }
        return value;
    }

    function toastDispose(toast) {
        if (toast && toast._element !== null) {
            if (toastPlacementContainer) {
                toastPlacementContainer.classList.remove(selectedType);
                DOMTokenList.prototype.remove.apply(toastPlacementContainer.classList, selectedPlacement);
            }
            toast.dispose();
        }
    }
    function fireToastEvent(type,message) {

        
        
        const toastPlacementContainer = document.querySelector('.toast-placement-ex');
        let selectedType, selectedPlacement, toastPlacement;

        $("#toastBody").text(message);

        if (toastPlacement) {
            toastDispose(toastPlacement);
        }

         selectedType = type; //'bg-primary';//document.querySelector('#selectTypeOpt').value;
         selectedPlacement = 'top-0 start-0';//document.querySelector('#selectPlacement').value.split(' ');

        toastPlacementContainer.classList.add(selectedType);
       // DOMTokenList.prototype.add.apply(toastPlacementContainer.classList, selectedPlacement);
        toastPlacement = new bootstrap.Toast(toastPlacementContainer);
        toastPlacement.show();

    }

    

    let inputAmount = document.querySelectorAll('input[data-validation-type="amount"]');


    inputAmount.forEach(item => {


        item.addEventListener('keypress', function (e) {



            var $this = this;

            var decimalLength = $(this).attr("data-decimal-point");

            if ((e.which != 46 || $this.val().indexOf('.') != -1) &&
                ((e.which < 48 || e.which > 57) &&
                    (e.which != 0 && e.which != 8))) {
                e.preventDefault();
            }

            var text = $(this).val();


            if ((e.which == 46) && (text.indexOf('.') == -1)) {
                setTimeout(function () {
                    if ($this.val().substring($this.val().indexOf('.')).length > 3) {
                        $this.val($this.val().substring(0, $this.val().indexOf('.') + 3));
                    }
                }, 1);
            }

            if ((text.indexOf('.') != -1) &&
                (text.substring(text.indexOf('.')).length > decimalLength) &&
                (e.which != 0 && e.which != 8) &&
                ($(this)[0].selectionStart >= text.length - decimalLength)) {
                e.preventDefault();
            }

        });

        item.addEventListener('input', function (e) {


            // var $this = $(this);


            var text = $(this).val();

            if (text.length > 0) {
                $(this).next('label').text(ConvertNumberToWords(text, "taka", "paisa"));
            }
            else {
                $(this).next('label').text("");
            }


        });

        item.addEventListener('blur', function () {

            var amount;
            var inputValue = parseFloat($(this).val())//$(this).val();
            var decimalPlaces = parseInt($(this).data('decimal-point'));
            var minAmount = parseFloat($(this).data('min-amt'));
            var maxAmount = parseFloat($(this).data('max-amt'));

            if (!isNaN(inputValue)) {


                if (!isNaN(minAmount)) {

                    if (inputValue < minAmount) {

                        $(this).val("");
                        alert('Value must be greater than ' + minAmount + '.');
                        $(this).next('label').text("");
                        return;
                    }
                }

                if (!isNaN(maxAmount)) {

                    if (inputValue > maxAmount) {
                        $(this).val("");
                        alert('Value must be less than ' + maxAmount + '.');
                        $(this).next('label').text("");
                        return;
                    }
                }


                if (!isNaN(decimalPlaces)) {
                    var formattedValue = parseFloat(inputValue).toFixed(decimalPlaces);
                    if (inputValue !== formattedValue) {
                        $(this).val(formattedValue);
                    }
                }


            }

        });

    });



    $('.datepicker').datepicker({

        dateFormat: 'dd/mm/yy',       
        onClose: function () {
            let validatedValue = validateDate($(this));
            $(this).val(validatedValue);
            
        }
    });

    $('.calenderPicker').click(function () {
        $(this).next('input.datepicker').focus();
        //$('.datepicker').focus();
    });



    let inputdatatype = document.querySelectorAll('input[data-type="datepicker"]');


    inputdatatype.forEach(item => {

        item.addEventListener('input', function (e) {


            let formattedValue = formatDate($(this));
            $(this).val(formattedValue);

        });

        item.addEventListener('blur', function (e) {


            let validatedValue = validateDate($(this));
            $(this).val(validatedValue);

        });

    });



    $('.numbersOnly').on('input', function (event) {
        this.value = this.value.replace(/[^0-9]/g, '');
    });

}