describe('All Styles Page', () => {

    beforeEach(() => {
        cy.allStylesPage();
    });

    it('Test Button to Add Style', () => {
        cy.getMatRaisedButtons('add').click(); 

        cy.url().should('include', '/create-or-update-style');

        cy.visit('/all-styles');  
        cy.wait('@allStyles');
    });

    it('Test Buttons to Edit Style', () => {
        cy.getMatIconButtons('edit')
        .then(($buttons) => {
            const buttonCount = $buttons.length;  
            cy.log(`Found ${buttonCount}`); // Debug log  
                
            for (let i = 0; i < buttonCount; i++) {  
                cy.visit('/all-styles');  
                cy.wait('@allStyles');  
                
                // Re-query and get the specific button by index  
                cy.getMatIconButtonByIndex('edit', i).click(); 
                cy.wait('@styleDetails');

                //Assertion  
                cy.url().should('include', `/create-or-update-style/${i + 1}`);
            }  

            cy.visit('/all-styles');  
            cy.wait('@allStyles');  
        });
    });

    it('Test Table headers', () => {
        cy.byTestId('styles-header-name')
            .should('have.text', 'Name');

        cy.byTestId('styles-header-action')
            .should('have.text', '');
    });

    it('Test table tbody', () => {
        let counter: number = 0;
        let expectations: string[] = [
            'Dummy Style 1',
            'edit',
            'Dummy Style 2',
            'edit',
            'Dummy Style 3',
            'edit',
        ];

        cy.byTestId('styles-cell').each(td$ => {
            expect(td$.text()).to.equal(expectations[counter]);
            counter++; 
        });
    });

});