const krPerDayString = ' kr./md';
const multiUspSelectedClass = ' MainUspBlock__Selected';

let sliderElement = document.querySelector('.UspPage__Slider');
let sliderValue = document.querySelector('.UspCalculationPage__EmployeesNumber');
let summarizedPrice = document.querySelector('.UspCalculationPage_SummarizedPrice');
let pricePerOneEmployeeElement = document.querySelector('#PricePerOneEmployee');
let mainUspBlock = document.querySelector('.MainUspBlock__Container');
let firstOptionalBlock = document.querySelector('.UspCalculationPage__BottomUspBlocksContainer .OptionalUspBlock__Container');
let secondOptionalBlock = document.querySelector('.UspCalculationPage__BottomUspBlocksContainer .OptionalUspBlock__Container:nth-of-type(2)');
let optionalUspPrice = document.querySelector('#UspOptionPrice');
let optionalUspText = document.querySelector('#UspOptionText');
let optionalUspPriceContainer = document.querySelector('.UspCalculationPage__AdditionalOptionContainer');

sliderElement.addEventListener("input", (event) => {
    sliderValue.textContent = event.target.value;
    let pricePerOneEmployee = parseInt(pricePerOneEmployeeElement.innerHTML);
    summarizedPrice.textContent = (event.target.value * pricePerOneEmployee) + krPerDayString;
})

firstOptionalBlock.addEventListener("click", () => {
    setupUspBlockClickListener(firstOptionalBlock, secondOptionalBlock);
})

secondOptionalBlock.addEventListener("click", () => {
    setupUspBlockClickListener(secondOptionalBlock, firstOptionalBlock);
})

function setupUspBlockClickListener(uspBlock, otherUspBlock) {
    
    setClassNames(uspBlock);
    calculatePricePerEmployee(uspBlock);
    removeSelectedClass(otherUspBlock);
    calculateSummarizedPrice();
}

function setClassNames(uspBlock) {
    if (!uspBlock.className.includes(multiUspSelectedClass)) {
        setOptionalUspBlockPriceContainer(uspBlock);
        uspBlock.className = uspBlock.className + multiUspSelectedClass;
    } else {
        removeSelectedClass(uspBlock);
        hideOptionalUspPriceContainer();
    }
}

function removeSelectedClass(uspBlock){
    uspBlock.className = uspBlock.className.replace(multiUspSelectedClass, '');
}

function setOptionalUspBlockPriceContainer(uspBlock) {
    var uspBlockPrice = getUspBlockPrice(uspBlock);
    optionalUspPrice.textContent = uspBlockPrice + krPerDayString;
    optionalUspText.textContent = getTitleText(uspBlock);
    optionalUspPriceContainer.style.display = 'block';

}

function hideOptionalUspPriceContainer(){
    optionalUspPriceContainer.style.display = 'none';
}

function calculatePricePerEmployee(uspBlock) {
    let uspBlockPrice = getUspBlockPrice(uspBlock);
    let mainUspBlockPrice = getUspBlockPrice(mainUspBlock);

    pricePerOneEmployeeElement.textContent = (parseInt(uspBlockPrice) + parseInt(mainUspBlockPrice)).toString();
}

function getUspBlockPrice(uspBlock) {
    let findUspBlockPrice = uspBlock.getElementsByClassName('UspBlock__PriceValue');
    return findUspBlockPrice[0].value;
}

function getTitleText(uspBlock) {
    let findUspBlockPrice = uspBlock.getElementsByClassName('UspBlock__Title');
    return findUspBlockPrice[0].innerHTML;
}

function calculateSummarizedPrice(){
    let pricePerOneEmployee = parseInt(pricePerOneEmployeeElement.innerHTML);
    let sliderElementValue = parseInt(sliderElement.value);
    summarizedPrice.textContent = (sliderElementValue * pricePerOneEmployee) + krPerDayString;
}