describe('All Artists Page', () => {

    beforeEach(() => {
        cy.allArtistsPage();
    });

    it('Test Button to Add Artist', () => {
        cy.getMatRaisedButtons('add').click();
        cy.url().should('include', '/create-or-update-artist');

        cy.visit('/all-artists');  
        cy.wait('@allArtists');
    });

    it('Test Buttons to Edit Artist', () => {
        cy.getMatIconButtons('edit')
        .then(($buttons) => {
            const buttonCount = $buttons.length;  
            cy.log(`Found ${buttonCount}`); // Debug log  
                
            for (let i = 0; i < buttonCount; i++) {  
                cy.visit('/all-artists');  
                cy.wait('@allArtists');  
                
                // Re-query and get the specific button by index  
                cy.getMatIconButtonByIndex('edit', i).click(); 
                cy.wait('@artistDetails');

                //Assertion  
                cy.url().should('include', `/create-or-update-artist/${i + 1}`);
            }  

            cy.visit('/all-artists');  
            cy.wait('@allArtists');  
        });
    });

    it('Test table thead', () => {
        let counter: number = 0;
        let expectations: string[] = [
            'Name',
            'Years',
            ''
        ];
        
        cy.byTestId('artists-header').each($th => {
            expect($th.text()).to.equal(expectations[counter]);
            counter++;            
        });
    });

    it('Test table tbody', () => {
        let counter: number = 0;
        let expectations: string[] = [
            'Dummy Artist 1',
            '1995 - ',
            'edit',
            'Dummy Artist 2',
            '1996 - ',
            'edit',
            'Dummy Artist 3',
            '1997 - ',
            'edit',
        ];

        cy.byTestId('artists-cell').each(td$ => {
            expect(td$.text()).to.equal(expectations[counter]);
            counter++; 
        });
    });

    it('mat-paginator exists', () => {
        cy.wait('@allArtists');
        cy.get('mat-paginator').should('exist', true);
    });

});