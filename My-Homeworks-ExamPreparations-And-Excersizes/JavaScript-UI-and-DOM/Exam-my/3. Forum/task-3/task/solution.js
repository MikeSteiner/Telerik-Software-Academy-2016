function solve() {
	return function() {

		// Handlebars.registerHelper('safeLink', function(passedString) {
		// 	var theString = passedString.substring(0,150);
        //
		// 	var isLink = theString.includes('<') || theString.includes('>');
		// 	if(isLink){
		// 		theString.replace('<', '&lt;');
		// 		theString.replace('>', '&gt;');
		// 	}
        //
		// 	return new Handlebars.SafeString(theString)
		// });

		var template = [
			'<h1>{{title}}</h1>',
			'<ul>',
				'{{#each posts}}',
					'<li>',
						'<div class="post">',
							'<p class="author">',
								'{{#if author}}',
									'<a class="user" href="/user/{{author}}">{{author}}</a>',
								'{{else}}',
									'<a class="anonymous">Anonymous</a>',
								'{{/if}}',
							'</p>',
							'<pre class="content">{{{text}}}</pre>',
						'</div>',
						'<ul>',
							'{{#each comments}}',
								'{{#if deleted}}',
								'{{else}}',
									'<li>',
										'<div class="comment">',
											'<p class="author">',
												'{{#if author}}',
													'<a class="user" href="/user/{{author}}">{{author}}</a>',
												'{{else}}',
													'<a class="anonymous">Anonymous</a>',
												'{{/if}}',
											'</p>',
											'<pre class="content">{{{text}}}</pre>',
										'</div>',
									'</li>',
								'{{/if}}',
							'{{/each}}',
						'</ul>',
					'</li>',
				'{{/each}}',
			'</ul>'
		].join('\n');

		return template;
	}
}

// submit the above

if(typeof module !== 'undefined') {
	module.exports = solve;
}
