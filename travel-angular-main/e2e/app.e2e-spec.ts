import { TravelAppTemplatePage } from './app.po';

describe('TravelApp App', function() {
  let page: TravelAppTemplatePage;

  beforeEach(() => {
    page = new TravelAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
