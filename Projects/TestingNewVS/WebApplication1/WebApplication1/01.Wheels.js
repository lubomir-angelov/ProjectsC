function Solve(input) {
	var wheels = parseInt(input[0]);
	var count = 0;
	var v1 = 4, v2 = 10, v3 = 3;

	for (var i = 0; i < wheels / v1 + 1; i++) {
		for (var j = 0; j < wheels / v2 + 1; j++) {
			for (var k = 0; k < wheels / v3 + 1; k++)
			{
				var all = (i * v1) + (j * v2) + (k * v3);
				if (all === s)
				{
					count++;
				}
			}
		}
	}

	console.log(count);
}