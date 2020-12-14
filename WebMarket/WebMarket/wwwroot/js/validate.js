$("#register").validate({
	rules: {
		"customer.Name": {
			required: true,
			maxlength: 25
		},
		"customer.Address": {
			required: true,
			min: 8,
			max:50
		},
		"customer.Phone": {
			required: true,
			number:true,
			min: 10
		},
		"customer.Date": {
			required: true,
			min: 10
		}
	}
});