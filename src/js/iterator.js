var iterator = function (input, operation) {
	
	var result = [];

	for (var i = 0; i < input.length; i++){
		result.push(operation(input[i]));
	}

	return result;
}

var square = function(x) { return x * x };

console.log(iterator([2,4,8], square));